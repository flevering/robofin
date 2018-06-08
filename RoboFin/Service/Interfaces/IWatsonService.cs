using System;
using System.Xml.Linq;
using Model;

namespace Service
{
    public interface IWatsonService
    {

        XObject ProcessMessage(WatsonModel message, string path, string workSpaceId, string authCredentials);
    }
}
