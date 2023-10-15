/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bd;

/**
 *
 * @author mathe
 */
import java.sql.*;

public class Bd {

    private static Connection con = null;
    private static String driver = "com.mysql.jdbc.Driver";
    private static String url = "jdbc:mysql://localhost/disciplina";
    private static String usuario = "root";
    private static String senha = "vertrigo";

    public static Connection getCon() {
        try {
            if (con == null || con.isClosed()) {
                Class.forName(driver);
                con = DriverManager.getConnection (url, usuario, senha);
                
            }
        } catch (Exception e){
            System.out.println(" erro na conexão\n" + e.getMessage());
        }
        return con;
    }
    public static void setCon (Connection cone){
        con = cone;
    }
}
