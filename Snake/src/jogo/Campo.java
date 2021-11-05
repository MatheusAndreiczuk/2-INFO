/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jogo;

import java.awt.Color;
import java.awt.Font;
import java.awt.FontMetrics;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.geom.Rectangle2D;
import java.util.Random;
import javax.swing.ImageIcon;
import javax.swing.JPanel;
import javax.swing.Timer;

public class Campo extends JPanel implements ActionListener {

    Fruta fruta;
    Fruta2 fruta2;
    Fruta2 fruta3;
    Fruta2 fruta4;
    Fruta2 fruta5;
    Fruta2 fruta6;
    Fruta2 fruta7;
    Fruta2 fruta8;
    Fruta2 fruta9;
    Fruta2 fruta10;
    Fruta2 fruta11;
    
    Cobra cobra;
    Cobra corpo[] = new Cobra[1000];
    Cenario cenario[] = new Cenario[10];
    int tamanhocenario = 4;
    int tamanho = 3;
    Timer t;
    Image fundo;
    int pontoJ = 0;
    int vida = 3;
    int add = 0;
    String msg = "";

    public Campo(int largura, final int altura) {
        setFocusable(true);
        setDoubleBuffered(true);
        setSize(largura, altura);
        fundo = new ImageIcon(this.getClass().getResource("/imagens/preto.jpg")).getImage().getScaledInstance(largura,
                altura, 1);
        inicializa();
        repaint();
        t = new Timer(100, this);
        t.start();
        addKeyListener(new KeyAdapter() {
            public void keyPressed(KeyEvent e) {
                int tecla = e.getKeyCode();
                if (tecla == KeyEvent.VK_UP) {
                    cobra.setDy(-20);
                    cobra.setDx(0);
                }
                if (tecla == KeyEvent.VK_DOWN) {
                    cobra.setDy(20);
                    cobra.setDx(0);
                }
                if (tecla == KeyEvent.VK_LEFT) {
                    cobra.setDx(-20);
                    cobra.setDy(0);
                }
                if (tecla == KeyEvent.VK_RIGHT) {
                    cobra.setDx(20);
                    cobra.setDy(0);
                }
                if (tecla == 'P' || tecla == 'p') {
                    if (t.isRunning()) {
                        msg = "Pausa";
                        repaint();
                        t.stop();
                    } else {
                        t.restart();
                        msg = "";
                    }
                }
                if (tecla == 'r' || tecla == 'R') {
                    inicializa();
                    t.start();
                }
                if (tecla == KeyEvent.VK_SPACE && vida == 0) {
                    msg = "";
                    t.start();
                }
            }
        });
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        for (int i = tamanho - 1; i > 0; i--) {
            corpo[i].setX(corpo[i - 1].getX());
            corpo[i].setY(corpo[i - 1].getY());
        }
        corpo[0].setX(cobra.getX());
        corpo[0].setY(cobra.getY());
        cobra.mexer();
        if (verificaColisaoFruta(fruta, cobra)) {
            corpo[tamanho++] = new Cobra();
            add++;
            posicionaFruta();
        }
        if (verificaColisaoFruta2(fruta2, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta2(fruta3, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta2(fruta4, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta2(fruta5, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta2(fruta6, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta2(fruta7, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta2(fruta8, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta2(fruta9, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta2(fruta10, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta2(fruta11, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoFruta(fruta, cobra)) {
            t.stop();
            add = 0;
            msg = "Game over";
        }
        if (verificaColisaoCorpo()) {
            t.stop();
            add = 0;
            msg = "Game Over";
        }
        if (verificaColisaoCenario()) {
            t.stop();
            add = 0;
            msg = "Game Over";
        }
        repaint();
    }

    private void posicionaFruta() {
        boolean ok = false;
        int x, y;
        int a, b, c, d, e, f, g, h, j, k, l, m, n, o, p, q, r, s, t, u;
        while (!ok) {
            ok = true;
            x = new Random().nextInt(this.getWidth());
            y = new Random().nextInt(this.getHeight());
            a = new Random().nextInt(this.getWidth());
            b = new Random().nextInt(this.getHeight());
            c = new Random().nextInt(this.getWidth());
            d = new Random().nextInt(this.getHeight());
            e = new Random().nextInt(this.getHeight());
            f = new Random().nextInt(this.getHeight());
            g = new Random().nextInt(this.getHeight());
            h = new Random().nextInt(this.getHeight());
            j = new Random().nextInt(this.getHeight());
            k = new Random().nextInt(this.getHeight());
            l = new Random().nextInt(this.getHeight());
            m = new Random().nextInt(this.getHeight());
            n = new Random().nextInt(this.getHeight());
            o = new Random().nextInt(this.getHeight());
            p = new Random().nextInt(this.getHeight());
            q = new Random().nextInt(this.getHeight());
            r = new Random().nextInt(this.getHeight());
            s = new Random().nextInt(this.getHeight());
            t = new Random().nextInt(this.getHeight());
            u = new Random().nextInt(this.getHeight());
            fruta2 = new Fruta2(a, b);
            fruta3 = new Fruta2(c, d);
            fruta4 = new Fruta2(e, f);
            fruta5 = new Fruta2(g, h);
            fruta6 = new Fruta2(j, k);
            fruta7 = new Fruta2(l, m);
            fruta8 = new Fruta2(n, o);
            fruta9 = new Fruta2(p, q);
            fruta10 = new Fruta2(r, s);
            fruta11 = new Fruta2(t, u);
            fruta = new Fruta(x, y);
            if (verificaColisaoFruta(fruta, cobra)) {
                ok = false;
            }
            for (int i = 0; i < tamanho; i++) {
                if (verificaColisaoFruta(fruta, corpo[i])) {
                    ok = false;
                }
            }
            for (int i = 0; i < tamanhocenario; i++) {
                if (verificaColisaoFruta(fruta, fruta2, fruta3, fruta4, fruta5, fruta6, fruta7, fruta8, fruta9, fruta10, fruta11, cenario[i])) {
                    ok = false;
                }
            }
        }
    }
    


    private void inicializa() {
        cobra = new Cobra(500, 400);
        cobra.setDx(-20);
        corpo[0] = new Cobra(520, 400);
        corpo[1] = new Cobra(540, 400);
        corpo[2] = new Cobra(560, 400);
        msg = "";
        tamanho = 3;
        cenario1();
        posicionaFruta();
    }

    private boolean verificaColisaoFruta(Fruta b, Cobra r) {
        if (r.getLimites().intersects(b.getLimites())) {
            return true;
        } else {
            return false;
        }
    }
    
    private boolean verificaColisaoFruta2(Fruta2 c, Cobra r) {
        if (r.getLimites().intersects(c.getLimites())) {
            return true;
        } else {
            return false;
        }
    }

    private boolean verificaColisaoFruta(Fruta b, Fruta2 c, Fruta2 d, Fruta2 e, Fruta2 f, Fruta2 g, Fruta2 h, Fruta2 i, Fruta2 j, Fruta2 k, Fruta2 l, Cenario r) {
        if (r.getLimites().intersects(b.getLimites()) || r.getLimites().intersects(c.getLimites()) || r.getLimites().intersects(d.getLimites()) || r.getLimites().intersects(e.getLimites())
                || r.getLimites().intersects(f.getLimites()) || r.getLimites().intersects(g.getLimites()) || r.getLimites().intersects(g.getLimites())
                || r.getLimites().intersects(g.getLimites()) || r.getLimites().intersects(h.getLimites()) || r.getLimites().intersects(i.getLimites())
                || r.getLimites().intersects(j.getLimites()) || r.getLimites().intersects(k.getLimites()) || r.getLimites().intersects(l.getLimites())) {
            return true;
        } else {
            return false;
        }
    }

    private boolean verificaColisaoCorpo() {
        for (int i = 0; i < tamanho; i++) {
            if (cobra.getLimites().intersects(corpo[i].getLimites())) {
                return true;
            }
        }
        return false;
    }

    private boolean verificaColisaoCenario() {
        for (int i = 0; i < tamanhocenario; i++) {
            if (cobra.getLimites().intersects(cenario[i].getLimites())) {
                return true;
            }
        }
        return false;
    }

    @Override
    public void paint(Graphics g) {
        g.drawImage(fundo, 0, 0, null);
        g.setColor(Color.WHITE);
        g.drawImage(cobra.getImagem(), (int) cobra.getX(), (int) cobra.getY(), this);
        for (int i = 0; i < tamanho; i++) {
            g.drawImage(corpo[i].getImagem(), (int) corpo[i].getX(), (int) corpo[i].getY(), this);
        }
        for (int i = 0; i < tamanhocenario; i++) {
            g.drawImage(cenario[i].getImagem(), (int) cenario[i].getX(), (int) cenario[i].getY(), this);
        }
        g.drawImage(fruta.getImagem(), (int) fruta.getX(), (int) fruta.getY(), this);
        g.drawImage(fruta2.getImagem(), (int) fruta2.getX(), (int) fruta2.getY(), this);
        if(add >= 1){
             g.drawImage(fruta2.getImagem(), (int) fruta3.getX(), (int) fruta3.getY(), this);
        }
        if(add >= 2){
             g.drawImage(fruta2.getImagem(), (int) fruta4.getX(), (int) fruta4.getY(), this);
        }
        if(add >= 3){
             g.drawImage(fruta2.getImagem(), (int) fruta5.getX(), (int) fruta5.getY(), this);
        }
        if(add >= 4){
             g.drawImage(fruta2.getImagem(), (int) fruta6.getX(), (int) fruta6.getY(), this);
        }
        if(add >= 5){
             g.drawImage(fruta2.getImagem(), (int) fruta7.getX(), (int) fruta7.getY(), this);
        }
        if(add >= 6){
             g.drawImage(fruta2.getImagem(), (int) fruta8.getX(), (int) fruta8.getY(), this);
        }
        if(add >= 7){
             g.drawImage(fruta2.getImagem(), (int) fruta9.getX(), (int) fruta9.getY(), this);
        }
        if(add >= 8){
             g.drawImage(fruta2.getImagem(), (int) fruta10.getX(), (int) fruta10.getY(), this);
        }
        if(add >= 9){
             g.drawImage(fruta2.getImagem(), (int) fruta11.getX(), (int) fruta11.getY(), this);
        }
        Font f = new Font("Arial", Font.BOLD, 20);
        g.setFont(f);
        FontMetrics fm = g.getFontMetrics(f);
        Rectangle2D rect = fm.getStringBounds(msg, g);
        int textWidth = (int) (rect.getWidth());
        int panelWidth = this.getWidth();
        int x = (panelWidth - textWidth) / 2;
        g.drawString(msg, x, 3 * (this.getHeight() / 4));
    }

    private void cenario1() {
        cenario[0] = new Cenario(0, 0, 25, 700);
        cenario[1] = new Cenario(0, 0, 1000, 25);
        cenario[2] = new Cenario(0, 680, 1000, 25);
        cenario[3] = new Cenario(970, 0, 25, 700);
        cenario[4] = new Cenario(200, 100, 25, 500);
        cenario[5] = new Cenario(770, 100, 25, 500);
        tamanhocenario = 6;
    }
}
