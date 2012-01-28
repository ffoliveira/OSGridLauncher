using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookComputing.XmlRpc;
using System.Collections;

namespace OSGridLauncher
{
    [XmlRpcUrl("http://localhost:9000/")]
    public interface RemoteOpensim : IXmlRpcProxy
    {
        [XmlRpcMethod("admin_save_oar")]
        XmlRpcStruct admin_save_oar(XmlRpcStruct Parameters);

        [XmlRpcMethod("admin_load_oar")]
        XmlRpcStruct admin_load_oar(XmlRpcStruct Parameters);

        [XmlRpcMethod("admin_shutdown")]
        XmlRpcStruct admin_shutdown(XmlRpcStruct Parameters);
    }

    class OSRemoteAdmin 
    {
        private string mServer;
        private string mSenha;

        public string server
        {
            get { return mServer; }
            set { mServer = value; }
        }

        public string password
        {
            get { return mSenha; }
            set { mSenha = value; }
        }

        public bool admin_shutdown(string password)
        {
            XmlRpcStruct shutAccept = new XmlRpcStruct();
            XmlRpcStruct shutParms = new XmlRpcStruct();

            shutParms.Add("password", password);

            RemoteOpensim admin = XmlRpcProxyGen.Create<RemoteOpensim>();

            shutAccept = admin.admin_shutdown(shutParms);

            bool retShut = false;

            foreach (DictionaryEntry ReturnResults in shutAccept)
             {
                 if ((ReturnResults.Key.ToString() == "success") && ( (bool)ReturnResults.Value) )
                 {
                     retShut = true;
                     break;
                 }
            }
 
            return retShut;
        }

        public bool admin_save_oar(string password, string nomeRegiao, string oarfile)
        {
            XmlRpcStruct saveAccept = new XmlRpcStruct();
            XmlRpcStruct saveParms = new XmlRpcStruct();

            saveParms.Add("password", password);
            saveParms.Add("region_name", nomeRegiao);
            saveParms.Add("filename", oarfile);

            RemoteOpensim admin = XmlRpcProxyGen.Create<RemoteOpensim>();

            try
            {
                saveAccept = admin.admin_save_oar(saveParms);
            }
            catch
            {
                return false;
            }

            bool retShut = true;

            /*
            foreach (DictionaryEntry ReturnResults in saveAccept)
            {
                if ((ReturnResults.Key.ToString() == "success") && ((bool)ReturnResults.Value))
                {
                    retShut = true;
                    break;
                }
            }
            */

            return retShut;
        }

        public bool admin_restore_oar(string password, string nomeRegiao, string oarfile)
        {
            XmlRpcStruct saveAccept = new XmlRpcStruct();
            XmlRpcStruct saveParms = new XmlRpcStruct();

            saveParms.Add("password", password);
            saveParms.Add("region_name", nomeRegiao);
            saveParms.Add("filename", oarfile);

            RemoteOpensim admin = XmlRpcProxyGen.Create<RemoteOpensim>();

            try
            {
                saveAccept = admin.admin_load_oar(saveParms);
            }
            catch
            {
                return false;
            }

            bool retShut = true;

            return retShut;
        }
    }

}
