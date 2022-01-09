﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService_2Way_101
{
    [ServiceContract]
    interface IClientCallBack
    {
        [OperationContract(IsOneWay = true)]
        void pesanKirim(string user, string pesan);
    }
}
