/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package console;

import polígono.Polígono;
/**
 *
 * @author mathe
 */
public class Console {  
    public static void main(String[] args) {
        Polígono calc=new Polígono();
        calc.setBase(0);
        calc.setAltura(0);
        calc.area();
        System.out.println("A área do quadrado é" +calc.getResultado());
        calc.perimetra();
        System.out.println("O perímetro é" +calc.getResultado());
        calc.areaa();
        System.out.println("A área do triângulo é" +calc.getResultado());        
        }
    }


                

