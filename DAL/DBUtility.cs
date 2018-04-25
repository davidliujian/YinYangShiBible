using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBUtility
    {
        //读取配置文件 连接数据库语句  
        public static string strCon = ConfigurationManager.ConnectionStrings["YYS_SQLConnString"].ConnectionString;
        
        //实例化连接对象 con  
        SqlConnection con = new SqlConnection(strCon);

        //检测连接是否打开  
        public void chkConnection()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        //执行语句，返回该语句查询的数据行的总数  
        public int returnRowCount(string strSQL)
        {
            chkConnection();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0].Rows.Count;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 从数据库中查询数据的,返回为DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet query(string sql)
        {
            chkConnection();
            DataSet ds = new DataSet();//DataSet是表的集合
            SqlDataAdapter da = new SqlDataAdapter(sql, con);//从数据库中查询
            da.Fill(ds);//将数据填充到DataSet
            conClose();//关闭连接
            return ds;//返回结果
        }

        /// <summary>
        /// 更新数据库
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int update(string sql)
        {
            chkConnection();
            SqlCommand oc = new SqlCommand();//表示要对数据源执行的SQL语句或存储过程
            oc.CommandText = sql;//设置命令的文本
            oc.CommandType = CommandType.Text;//设置命令的类型
            oc.Connection = con;//设置命令的连接
            int x = oc.ExecuteNonQuery();//执行SQL语句
            conClose();//关闭连接
            return x;  //返回一个影响行数
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void conClose()
        {
            if (con.State == ConnectionState.Open)
            {
                //判断数据库的连接状态，如果状态是打开的话就将它关闭
                con.Close();
            }
        }
    }
}
