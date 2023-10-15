/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bean;
import java.io.Serializable;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;
import javax.faces.model.DataModel;

import javax.faces.model.ListDataModel;
import persistencia.ClienteDAO;
import vo.Cliente;

/**
 *
 * @author mathe
 */

@ManagedBean
@RequestScoped
public class TelaLocalizaBeanCliente implements Serializable {

    private DataModel<Cliente> lista;
    ClienteDAO cd = new ClienteDAO();
    private Cliente cliente = new Cliente();

    public TelaLocalizaBeanCliente() {
    }

    public String atualizaLista() {
        lista = new ListDataModel<>(cd.pesquisa());
        return "listaclientes";
    }

    public DataModel<Cliente> getLista() {
        atualizaLista();
        return lista;
    }

    public Cliente clienteSelecionado() {
        Cliente c = lista.getRowData();
        return c;
    }

    public String excluir() {
        Cliente c = clienteSelecionado();
        cd.exclui(c);
        return "index";
    }

    public String novo() {
        cliente = new Cliente();
        return "cadastrocliente";
    }

    public String editar() {
        Cliente c = clienteSelecionado();
        setCliente(c);
        return "cadastrocliente";
    }

    public String salva() {
        cd.salva(cliente);
        return "listaclientes";
    }

    public String cancela() {
        return "index";
    }

    /**
     * @return the cliente
     */
    public Cliente getCliente() {
        return cliente;
    }

    /**
     * @param cliente the cliente to set
     */
    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }
}
