using NChardet;
using System.IO;
using System.Linq;
using System.Diagnostics;

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
                const int lang = 1;
                //1.Japanese
                //2.Chinese
                //3.Simplified Chinese
                //4.Traditional Chinese
                //5.Korean
                //6.Dont know(Ĭ��)
                //��ָ���������ʵ����Detector
                Detector det = new Detector(lang);
                //��ʼ��
                MyCharsetDetectionObserver cdo = new MyCharsetDetectionObserver();
                det.Init(cdo);
                if (!File.Exists(filename))
                {
                    return "";
                }
                Debug.WriteLine($"--{Path.GetFileName(filename)}--");
                stream = File.OpenRead(filename);// response.GetResponseStream();

                int len;
                var buf      = new byte[1024];
                bool done    = false;
                bool isAscii = true;

                while ((len = stream.Read(buf, 0, buf.Length)) != 0)
                {
                    // ̽���Ƿ�ΪAscii����
                    if (isAscii)
                        isAscii = Detector.isAscii(buf, len);

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
                    Debug.WriteLine("CHARSET = ASCII");
                    return "ASCII";
                }
                else if (cdo.Charset != null)
                {
                    Debug.WriteLine($"CHARSET = {cdo.Charset}");
                    return cdo.Charset;
                }

                var prob = det.getProbableCharsets();

                var probEncode = prob.Aggregate("", (current, item) => current + item + " ");
                Debug.WriteLine($"Probable Charset = {probEncode}");
                foreach (string item in prob)
                {
                    switch (item)
                    {
                        case "Shift_JIS":
                            return item;
                        case "EUC-JP":
                            return item;
                    }
                }
                return "GB18030";//to avoid exception while can not determine encode.
            }
            finally
            {
                stream?.Close();
            }
        }
    }
    internal class MyCharsetDetectionObserver : ICharsetDetectionObserver
    {
        public string Charset;

        public void Notify(string charset)
        {
            Charset = charset;
        }
    }
}
