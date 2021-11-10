/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pacman;

import java.awt.Image;
import javax.swing.ImageIcon;

public class PacMan extends Thread {

    private Image imagem = new ImageIcon(getClass().getResource("/imagens/pacman_0_0.png")).getImage()
            .getScaledInstance(20, 20, 0);
    private int dx = 1;
    private int dy = 0;
    private int x = 9;
    private int y = 16;
    private int altura = 20;
    private int largura = 20;
    private int seq = 0;

    public PacMan(int largura, int altura) {
        this.largura = largura;
        this.altura = altura;
        start();
    }

    public void move() {
        setX(getX() + getDx());
        setY(getY() + getDy());
    }

    @Override
    public void run() {
        while (true) {
            int direcao = 0;
            if (getDy() > 0) {
                direcao = 1;
            }
            if (getDy() < 0) {
                direcao = 3;
            }
            if (getDx() < 0) {
                direcao = 2;
            }
            if (getSeq() > 3) {
                setSeq(0);
            }
            setImagem(new ImageIcon(getClass().getResource("/imagens/pacman_" + direcao + "_" + getSeq() + ".png")).getImage().getScaledInstance((int) getLargura(), (int) getAltura(), 0));
            setSeq(getSeq() + 1);
            try {
                this.sleep(100);
            } catch (Exception e) {
                System.out.println("Erro:" + direcao + "_" + getSeq() + e.getMessage());
            }
        }
    }

    /**
     * @return the imagem
     */
    public Image getImagem() {
        return imagem;
    }

    /**
     * @param imagem the imagem to set
     */
    public void setImagem(Image imagem) {
        this.imagem = imagem;
    }

    /**
     * @return the dx
     */
    public int getDx() {
        return dx;
    }

    /**
     * @param dx the dx to set
     */
    public void setDx(int dx) {
        this.dx = dx;
    }

    /**
     * @return the dy
     */
    public int getDy() {
        return dy;
    }

    /**
     * @param dy the dy to set
     */
    public void setDy(int dy) {
        this.dy = dy;
    }

    /**
     * @return the x
     */
    public int getX() {
        return x;
    }

    /**
     * @param x the x to set
     */
    public void setX(int x) {
        this.x = x;
    }

    /**
     * @return the y
     */
    public int getY() {
        return y;
    }

    /**
     * @param y the y to set
     */
    public void setY(int y) {
        this.y = y;
    }

    /**
     * @return the altura
     */
    public int getAltura() {
        return altura;
    }

    /**
     * @param altura the altura to set
     */
    public void setAltura(int altura) {
        this.altura = altura;
    }

    /**
     * @return the largura
     */
    public int getLargura() {
        return largura;
    }

    /**
     * @param largura the largura to set
     */
    public void setLargura(int largura) {
        this.largura = largura;
    }

    /**
     * @return the seq
     */
    public int getSeq() {
        return seq;
    }

    /**
     * @param seq the seq to set
     */
    public void setSeq(int seq) {
        this.seq = seq;
    }
}
