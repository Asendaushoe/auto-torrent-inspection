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
                return prob.First();
            }
            finally
            {
                stream?.Close();
            }
        }

        // 0000 0000-0000 007F - 0xxxxxxx                   (ascii converts to 1 octet!)
        // 0000 0080-0000 07FF - 110xxxxx 10xxxxxx          ( 2 octet format)
        // 0000 0800-0000 FFFF - 1110xxxx 10xxxxxx 10xxxxxx ( 3 octet format)
        /// <summary>
        /// Determines wether a text file is encoded in UTF by analyzing its context.
        /// </summary>
        /// <param name="filePath">The text file to analyze.</param>
        public static bool IsUTF8(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            if (bytes.Length <= 0) return false;
            bool asciiOnly = true;
            int continuationBytes = 0;
            foreach (var item in bytes)
            {
                if ((sbyte)item < 0) asciiOnly = false;
                if (continuationBytes != 0)
                {
                    if ((item & 0xC0) != 0x80u) return false;
                    --continuationBytes;
                }
                else
                {
                    if (item < 0x80u) continue;
                    var temp = item;
                    do
                    {
                        temp <<= 1;
                        ++continuationBytes;
                    } while ((sbyte)temp < 0);
                    --continuationBytes;
                    if (continuationBytes == 0) return false;
                }
            }
            return continuationBytes == 0 && !asciiOnly;
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
