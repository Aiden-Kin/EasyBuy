using EasyBuy_DAL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_BLL
{
public class MfaManager
    {
        public List<MfaModel> GetMfaList()
        {
            return new MfaServer().GetMfaList();
        }

        public int SetMfa(MfaModel mfaModel)
        {
            return new MfaServer().SetMfa(mfaModel);
        }

        public string GetBase32(string user)
        {
            List<MfaModel> mfaList = new MfaServer().GetMfaByBase32Key(user);
            if (mfaList.Count > 0)
            {
                int last = mfaList.Count - 1;
                return mfaList[last].CreateTime;
            }
            return null;
        }

        public int DeleteMfa(string base32Key)
        {
            return new MfaServer().DeleteMfa(base32Key);
        }
    }

}
