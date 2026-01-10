using MySql.Data.MySqlClient;

public static class DBUtil
{
    private static string conn = "server=localhost;database=perpustakaan;uid=root;pwd=;";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(conn);
    }
}
