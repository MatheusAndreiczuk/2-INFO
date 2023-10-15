/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bd;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;
import vo.Cliente;

/**
 *
 * @author mathe
 */
public class BdCliente {

    public void insere(Cliente cliente) {
        String sql = "insert into cliente (nome,endereco,cidade,uf,telefone,renda) values(?,?,?,?,?,?)";
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setString(1, cliente.getNome());
            ps.setString(2, cliente.getEndereco());
            ps.setString(3, cliente.getCidade());
            ps.setString(4, cliente.getUf());
            ps.setString(5, cliente.getTelefone());
            ps.setDouble(6, cliente.getRenda());
            ps.execute();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
    }

    public void salva(Cliente cliente) {
        if (cliente.getCodigo() == 0) {
            insere(cliente);
        } else {
            String sql = "update cliente set nome=?,endereco=?,cidade=?,uf=?,telefone=?,renda=? where codigo=?";
            try {
                PreparedStatement ps = Bd.getCon().prepareStatement(sql);
                ps.setInt(7, cliente.getCodigo());
                ps.setString(1, cliente.getNome());
                ps.setString(2, cliente.getEndereco());
                ps.setString(3, cliente.getCidade());
                ps.setString(4, cliente.getUf());
                ps.setString(5, cliente.getTelefone());
                ps.setDouble(6, cliente.getRenda());
                ps.execute();
            } catch (SQLException e) {
                System.out.println("Erro SQL: " + e.getMessage());
            }
        }
    }

    public Cliente localiza(int codigo) {
        String sql = "select * from cliente where codigo=?";
        Cliente registro = new Cliente();
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setInt(1, codigo);
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                registro.setCodigo(rs.getInt("codigo"));
                registro.setNome(rs.getString("nome"));
                registro.setEndereco(rs.getString("endereco"));
                registro.setCidade(rs.getString("cidade"));
                registro.setUf(rs.getString("uf"));
                registro.setTelefone(rs.getString("telefone"));
                registro.setRenda(rs.getDouble("renda"));
            }
        } catch (SQLException e) {
            System.out.println("Erro SQL: " + e.getMessage());
        }
        return registro;
    }

    public List pesquisa(String busca) {
        String sql = "select * from cliente where nome like ?";
        List lista = new ArrayList();
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setString(1, "%" + busca + "%");
            ResultSet rs = ps.executeQuery();
            while (rs.next()) {
                Cliente registro = new Cliente();
                registro.setCodigo(rs.getInt("codigo"));
                registro.setNome(rs.getString("nome"));
                registro.setEndereco(rs.getString("endereco"));
                registro.setCidade(rs.getString("cidade"));
                registro.setUf(rs.getString("uf"));
                registro.setTelefone(rs.getString("telefone"));
                registro.setRenda(rs.getDouble("renda"));
                lista.add(registro);
            }
        } catch (SQLException e) {
            System.out.println("Erro SQL: " + e.getMessage());
        }
        return lista;
    }

    public void exclui(int codigo) {
        String sql = "delete from cliente where codigo=?";
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setInt(1, codigo);
            ps.execute();
        } catch (SQLException e) {
            System.out.println("Erro SQL: " + e.getMessage());
        }
    }
}
