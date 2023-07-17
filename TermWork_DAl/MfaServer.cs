using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_DAL
{
    public class MfaServer
    {
        private List<MfaModel> ToMfaModelList(DataTable dt)
        {
            List<MfaModel> mfaList = new List<MfaModel>();
            foreach (DataRow row in dt.Rows)
            {
                MfaModel mfaModel = new MfaModel();
                mfaModel.Base32Key = row["Base32Key"].ToString();
                mfaModel.UserName = row["UserName"].ToString();
                mfaModel.CreateTime = row["CreateTime"].ToString();
                mfaList.Add(mfaModel);
            }
            return mfaList;
        }

        public List<MfaModel> GetMfaList()
        {
            string sqlStr = "SELECT * FROM tblMfa";
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            return ToMfaModelList(dt);
        }

        public int SetMfa(MfaModel mfaModel)
        {
            string setMfaSqlStr = $"INSERT INTO tblMfa (Base32Key, UserName, CreateTime) VALUES ('{mfaModel.Base32Key}', '{mfaModel.UserName}', '{mfaModel.CreateTime}')";
            return SqlHelper.ExecuteNonQuery(setMfaSqlStr);
        }

        public int DeleteMfa(string base32Key)
        {
            string deleteMfaSqlStr = $"DELETE FROM tblMfa WHERE Base32Key = '{base32Key}'";
            return SqlHelper.ExecuteNonQuery(deleteMfaSqlStr);
        }

        public List<MfaModel> GetMfaByBase32Key(string user)
        {
            string sqlStr = $"SELECT * FROM tblMfa WHERE UserName = '{user}'";
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            return ToMfaModelList(dt);
        }
    }
}
