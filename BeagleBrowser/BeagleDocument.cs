using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleBrowser
{
    public class BeagleDocument
    {
        //struct packet
        //{
        //    public byte[] Bytes;
        //};

        //private List<packet> capture;
        private List< byte[] > capture;
        private int maxPacketLength;

        public BeagleDocument()
        {
            capture = new List<byte[]>();
            maxPacketLength = 0;
        }

        public bool addPacket(String b)
        {
            b = b.TrimEnd();// '*', '\r', '\n');

            if (b.Length < 2) {
                //probably an empty string
                return false;
            }

            // parse string as array of bytes
            int len = (b.Length + 2) / 3;
            byte[] bytes = new byte[len];

            maxPacketLength = len > maxPacketLength ? len : maxPacketLength;

            Int32 index = 0;
 
            String[] asciiPairs = b.Split(' ');
            foreach (String a in asciiPairs)
            {
                bytes[index++] = Convert.ToByte( a, 16 );
            }

            if( bytes.Length != 0)
            {
                capture.Add( bytes );
                return true;
            }
            return false;
            
        }
        public int getMaxPacketLength()
        {
            return maxPacketLength;
        }
        public int getNumberOfPackets()
        {
            return capture.Count;
        }
        public byte[] getPacket(int index)
        {
            return capture.ElementAt(index);
        }
    }
}
