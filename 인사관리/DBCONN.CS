// (C) 정경환(khjung2053@gmail.com)
// Ver 1.0.1 - 2018.4.9

//using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

/*
// SQL Server
public class DBConn
{
    string connectionString = @"Server=.\SQLEXPRESS;Database=haksa;uid=sa;pwd=0000";
    //string connectionString = @"Server=192.168.0.5\SQLEXPRESS;Database=haksa;User=sa;Password=0000";

    public SqlConnection conn;

    public DBConn()
    {
        conn = new SqlConnection(connectionString);
        conn.Open();
    }

    public void Close()
    {
        conn.Close();
    }

    public SqlConnection GetConn()
    {
        return conn;
    }

    public void ExecuteNonQuery(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }

    public SqlDataReader ExecuteReader(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, conn);
        return cmd.ExecuteReader();
    }

    public object ExecuteScalar(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, conn);
        return cmd.ExecuteScalar();
    }
}
*/

// OleDb
public class DBConn
{
    // string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=학사2013.accdb";
    // string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db\학사2013.accdb";
    string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=인사관리.mdb";

    public OleDbConnection conn;

    public DBConn()
    {
        conn = new OleDbConnection(connectionString);
        conn.Open();
    }

    public void Close()
    {
        conn.Close();
    }

    public OleDbConnection GetConn()
    {
        return conn;
    }

    public void ExecuteNonQuery(string sql)
    {
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }

    public OleDbDataReader ExecuteReader(string sql)
    {
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        return cmd.ExecuteReader();
    }

    public object ExecuteScalar(string sql)
    {
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        return cmd.ExecuteScalar();
    }
}

