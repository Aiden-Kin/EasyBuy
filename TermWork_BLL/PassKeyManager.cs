using EasyBuy_DAL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PassKeyManager
{
    public List<PassKey> GetPassKeyList()
    {
        return new PassKeyServer().GetPassKeyList();
    }

    public int SetPassKey(PassKey passKey)
    {
        return new PassKeyServer().SetPassKey(passKey);
    }

    public string GetKeyTime(string passKey)
    {


        List<PassKey> keylist = new PassKeyServer().GetKeyTime(passKey);
        if (keylist.Count > 0)
        {
            return keylist[0].PassGenerateTime; ;
        }
        return null;
        
    }

    public int DeletePassKey(string passkey)
    {
        return new PassKeyServer().DeletePassKey(passkey);
    }
}

