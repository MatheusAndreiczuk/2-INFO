/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bean;

import bd.BdAluno;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import javax.faces.model.DataModel;
import javax.faces.model.ListDataModel;
import vo.Aluno;

@ManagedBean
@SessionScoped
/**
 *
 * @author mathe
 */
public class AlunoBean {

    private Aluno aluno; //ENCAPSULE aluno e lista ANTES DE PROSSEGUIR
    private final BdAluno bda = new BdAluno();
    private DataModel<Aluno> lista; //ENCAPSULE aluno e lista ANTES DE PROSSEGUIR

    public AlunoBean() {
        atualizaLista();
    }

    public String salva() {
        bda.salva(getAluno());
        atualizaLista();
        return "index";
    }

    public final void atualizaLista() {
        setLista((DataModel<Aluno>) new ListDataModel(bda.pesquisa("")));
    }

    public String exclui() {
        setAluno(getLista().getRowData());
        bda.exclui(getAluno().getCodigo());
        atualizaLista();
        return "";
    }

    public String novo() {
        setAluno(new Aluno());
        return "aluno";
    }

    public String edita() {
        setAluno(getLista().getRowData());
        return "aluno";
    }

    /**
     * @return the aluno
     */
    public Aluno getAluno() {
        return aluno;
    }

    /**
     * @param aluno the aluno to set
     */
    public void setAluno(Aluno aluno) {
        this.aluno = aluno;
    }

    /**
     * @return the lista
     */
    public DataModel<Aluno> getLista() {
        return lista;
    }

    /**
     * @param lista the lista to set
     */
    public void setLista(DataModel<Aluno> lista) {
        this.lista = lista;
    }
}
