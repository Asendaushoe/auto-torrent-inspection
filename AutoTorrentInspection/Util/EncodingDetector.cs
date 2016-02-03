using System;
using System.IO;
using NChardet;

namespace AutoTorrentInspection.Util
{
    public static class EncodingDetector
    {
        /// <summary>
        /// ��ȡ�ı��ļ�ʹ�õı���
        /// </summary>
        public static string GetEncoding(string filename)
        {
            Stream stream = null;
            try
            {
                int lang = 2;//
                //��ָ���������ʵ����Detector
                Detector det = new Detector(lang);
                //��ʼ��
                MyCharsetDetectionObserver cdo = new MyCharsetDetectionObserver();
                det.Init(cdo);

                stream = File.OpenRead(filename);// response.GetResponseStream();

                byte[] buf = new byte[1024];
                int len;
                bool done = false;
                bool isAscii = true;

                while ((len = stream.Read(buf, 0, buf.Length)) != 0)
                {
                    // ̽���Ƿ�ΪAscii����
                    if (isAscii)
                        isAscii = det.isAscii(buf, len);

                    // �������Ascii���룬���ұ���δȷ���������̽��
                    if (!isAscii && !done)
                        done = det.DoIt(buf, len, false);

                }
                stream.Close();
                stream.Dispose();
                //����DatEnd������
                //���������Ϊ�Ѿ�̽�������ȷ�ı��룬
                //����ڴ�ʱ����ICharsetDetectionObserver��Notify����
                det.DataEnd();

                if (isAscii)
                {
                    Console.WriteLine("CHARSET = ASCII");
                    return "ASCII";
                    //found = true;
                }
                else if (cdo.Charset != null)
                {
                    Console.WriteLine("CHARSET = {0}", cdo.Charset);
                    return cdo.Charset;
                }

                string[] prob = det.getProbableCharsets();
                foreach (string item in prob)
                {
                    Console.WriteLine("Probable Charset = " + item);
                    switch (item)
                    {
                        case "Shift_JIS":
                            return item;
                        case "EUC-JP":
                            return item;
                    }
                }
                return "";
            }
            finally
            {
                stream?.Close();
            }
        }
    }
    internal class MyCharsetDetectionObserver : NChardet.ICharsetDetectionObserver
    {
        public string Charset = null;

        public void Notify(string charset)
        {
            Charset = charset;
        }
    }
}
