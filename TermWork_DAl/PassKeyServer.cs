using EasyBuy_DAL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PassKeyServer
{
    private List<PassKey> ToModel(DataTable dt)
    {
        List<PassKey> passKeyList = new List<PassKey>();
        foreach (DataRow row in dt.Rows)
        {
            PassKey passKey = new PassKey();
            passKey.Passkey = row["Passkey"].ToString();
            passKey.PassGenerateTime = row["PassGenerateTime"].ToString();
            passKeyList.Add(passKey);
        }
        return passKeyList;
    }

    public List<PassKey> GetPassKeyList()
    {
        string sqlStr = "SELECT * FROM tblPassKey";
        DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
        return ToModel(dt);
    }

    public int SetPassKey(PassKey passKey)
    {
        string setPassKeySqlStr = string.Format("INSERT INTO tblPassKey VALUES ('{0}', '{1}')", passKey.Passkey, passKey.PassGenerateTime);
        return SqlHelper.ExecuteNonQuery(setPassKeySqlStr);
    }

    public int DeletePassKey(string passkey)
    {
        string deletePassKeySqlStr = string.Format("DELETE FROM tblPassKey WHERE Passkey = '{0}'", passkey);
        return SqlHelper.ExecuteNonQuery(deletePassKeySqlStr);
    }

    public List<PassKey> GetKeyTime(string key)
    {
        string sqlStr = string.Format("SELECT * FROM tblPassKey where Passkey = '{0}'",key);
        DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
        return ToModel(dt);
    }
}

