/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package polígono;

/**
 *
 * @author mathe
 */
public class Polígono {
    private double base;
    private double altura;
    private double resultado;
    
     public void area(){
        setResultado(getBase() * getAltura());
    }
    public void perimetra(){
        setResultado(2 * getBase() + 2 * getAltura());
    }
    public void areaa(){
        setResultado((getBase() * getAltura()) / 2);

    /**
     * @return the base
     */
    
    
   

    /**
     * @param args the command line arguments
     */
   
    
}

    /**
     * @return the base
     */
    public double getBase() {
        return base;
    }

    /**
     * @param base the base to set
     */
    public void setBase(double base) {
        this.base = base;
    }

    /**
     * @return the altura
     */
    public double getAltura() {
        return altura;
    }

    /**
     * @param altura the altura to set
     */
    public void setAltura(double altura) {
        this.altura = altura;
    }

    /**
     * @return the resultado
     */
    public double getResultado() {
        return resultado;
    }

    /**
     * @param resultado the resultado to set
     */
    public void setResultado(double resultado) {
        this.resultado = resultado;
    }
}
