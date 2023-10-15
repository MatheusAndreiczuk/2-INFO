/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bean;
import bd.BdDependente;
import bd.BdSocio;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import javax.faces.model.DataModel;
import javax.faces.model.ListDataModel;
import vo.Dependente;
import vo.Socio;
/**
 *
 * @author mathe
 */
@ManagedBean
@SessionScoped
public class ProjetoBean {
    private Dependente dependente = new Dependente();
    private final BdDependente bdaDependente = new BdDependente();
    private DataModel<Dependente> listaDependente;
    private Socio socio = new Socio();
    private final BdSocio bdaSocio=new BdSocio();
    private DataModel<Socio> listaSocio;
    private Integer SocioAtual = 0;
    
    public ProjetoBean() {
        atualizaListaSocio();
    }

    /**
     * @return the dependente
     */
    public Dependente getDependente() {
        return dependente;
    }

    /**
     * @param dependente the dependente to set
     */
    public void setDependente(Dependente dependente) {
        this.dependente = dependente;
    }

    /**
     * @return the lista
     */
    public DataModel<Dependente> getListaDependente() {
        return listaDependente;
    }

    /**
     * @param listaDependente
     * @param lista the lista to set
     */
    public void setListaDependente(DataModel<Dependente> listaDependente) {
        this.listaDependente = listaDependente;
    }

    public String salvaDependente() {
        bdaDependente.salva(dependente);
        refreshListaDependente();
        return "dependente";
    }

    public String atualizaListaDependente() {
        socio=listaSocio.getRowData();
        setSocioAtual((Integer) socio.getId());
        listaDependente = new ListDataModel(bdaDependente.pesquisa(getSocioAtual()));
        return "dependente";
    }
    public final void refreshListaDependente(){
        listaDependente = new ListDataModel(bdaDependente.pesquisa(getSocioAtual()));
    }

    public String excluiDependente() {
        dependente = listaDependente.getRowData();
        bdaDependente.exclui(dependente.getId());
        refreshListaDependente();
        return "";
    }

    public String novoDependente() {
        dependente = new Dependente();
        dependente.setIdSocio(SocioAtual);
        return "cadastro_dependente";
    }

    public String editaDependente() {
        dependente = listaDependente.getRowData();
        return "cadastro_dependente";
    }

    /**
     * @return the socio
     */
    public Socio getSocio() {
        return socio;
    }

    /**
     * @param socio the socio to set
     */
    public void setSocio(Socio socio) {
        this.socio = socio;
    }

    /**
     * @return the lista
     */
    public DataModel<Socio> getListaSocio() {
        return listaSocio;
    }

    /**
     * @param listaSocio
     * @param lista the lista to set
     */
    public void setListaSocio(DataModel<Socio> listaSocio) {
        this.listaSocio = listaSocio;
    }
    public String salvaSocio(){
        bdaSocio.salva(socio);
        atualizaListaSocio();
        return "index";
    }
    public final void atualizaListaSocio(){
        listaSocio=new ListDataModel(bdaSocio.pesquisa(""));
    }
    public String excluiSocio(){
        socio=listaSocio.getRowData();
        bdaSocio.exclui(socio.getId());
        atualizaListaSocio();
        return "";
    }
    public String novoSocio(){
        socio=new Socio();
        return "cadastro_socio";
    }
    public String editaSocio(){
        socio=listaSocio.getRowData();
        return "cadastro_socio";
    }

    /**
     * @return the SocioAtual
     */
    public Integer getSocioAtual() {
        return SocioAtual;
    }

    /**
     * @param SocioAtual the SocioAtual to set
     */
    public void setSocioAtual(Integer SocioAtual) {
        this.SocioAtual = SocioAtual;
    }
}

