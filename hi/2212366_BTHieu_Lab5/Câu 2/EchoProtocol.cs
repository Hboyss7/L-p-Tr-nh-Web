using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Extensions.Logging;

namespace Câu_2
{
    internal class EchoProtocol : IProtocol
    {
        public const int BUFSIZE = 32;

        private Socket clntSock;

        private ILogger logger;

        public EchoProtocol(Socket clntSock, ILogger logger)
        {
            this.clntSock = clntSock;
            this.logger = logger; 
        }
        public void handleclient ()
        {
            ArrayList entry = new ArrayList();
            entry.Add("Client address and port = " + clntSock.RemoteEndPoint);
            entry.Add("Thread = " + Thread.CurrentThread.GetHashCode());
            try
            {
                int recvMsgSize;
                int totalByteEchoed = 0;
                byte[] rcvBuffer = new byte[BUFSIZE];
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
