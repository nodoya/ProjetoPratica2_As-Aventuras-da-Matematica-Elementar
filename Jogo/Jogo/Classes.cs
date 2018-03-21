﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace Jogo
{
    public class Background
    {
        private int fase;
        private int estado { get; set; }

        public Background(int fase)
        {
            this.fase = fase;
            this.estado = 0;
        }

        ObjHeroi heroi;
        Bitmap heroiImg;

        ObjGame monstro;
        Bitmap monstroImg;

        Bitmap fundo;

        ObjEstatico arvore;
        Bitmap arvoreImg;

        ObjNpc mestre;
        Bitmap mestreImg;

        ObjNpc easterEgg;
        Bitmap easterEggImg;

        Game game = new Game();
        ObjGame[] objsDoGame;

        public int Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public void iniciarBatalha()
        {
            
        }


        public void carregarGame ()
        {
            switch (fase)
            {
                case 1:
                    {
                        //texto
                        //vc se chama shingetsu kun, um samurai muito respeitado
                        //sua vida inteira vc usou a força sobre tudo, até agora.
                        //vc chega na vila e ta tudo difrerente, vazia, e vc encontra o Senpaio, o mestre em matematica
                        //18,13
                        game.setOcupado(20, 2); game.setOcupado(21, 2); game.setOcupado(3, 4); game.setOcupado(3, 3); game.setOcupado(10, 8); game.setOcupado(15, 14); game.setOcupado(3, 2); game.setOcupado(4, 2); game.setOcupado(5, 2); game.setOcupado(6, 2); game.setOcupado(6, 3); game.setOcupado(5, 3); game.setOcupado(4, 3); game.setOcupado(4, 4); game.setOcupado(5, 4); game.setOcupado(6, 4); game.setOcupado(7, 15); game.setOcupado(7, 14); game.setOcupado(7, 13); game.setOcupado(6, 13); game.setOcupado(6, 12); game.setOcupado(6, 11); game.setOcupado(5, 11); game.setOcupado(5, 10); game.setOcupado(5, 9); game.setOcupado(6, 9); game.setOcupado(7, 9); game.setOcupado(8, 9); game.setOcupado(9, 9); game.setOcupado(10, 9); game.setOcupado(9, 8); game.setOcupado(8, 8); game.setOcupado(7, 8); game.setOcupado(6, 8); game.setOcupado(10, 9); game.setOcupado(11, 10); game.setOcupado(11, 11); game.setOcupado(11, 12); game.setOcupado(12, 13); game.setOcupado(12, 14); game.setOcupado(12, 15); game.setOcupado(11, 15); game.setOcupado(9, 15); game.setOcupado(8, 15); game.setOcupado(7, 15); game.setOcupado(14, 17); game.setOcupado(14, 16); game.setOcupado(15, 16); game.setOcupado(15, 15); game.setOcupado(16, 16); game.setOcupado(16, 17); game.setOcupado(15, 17); game.setOcupado(18, 15); game.setOcupado(20, 15); game.setOcupado(19, 15); game.setOcupado(20, 15); game.setOcupado(21, 15); game.setOcupado(21, 15); game.setOcupado(22, 15); game.setOcupado(21, 15); game.setOcupado(23, 15); game.setOcupado(23, 14); game.setOcupado(22, 14); game.setOcupado(21, 14); game.setOcupado(20, 14); game.setOcupado(19, 14); game.setOcupado(18, 14); game.setOcupado(18, 14); game.setOcupado(18, 12); game.setOcupado(18, 13); game.setOcupado(17, 12); game.setOcupado(17, 11); game.setOcupado(17, 10); game.setOcupado(18, 9); game.setOcupado(18, 8); game.setOcupado(19, 8); game.setOcupado(20, 8); game.setOcupado(21, 8); game.setOcupado(22, 8); game.setOcupado(22, 9); game.setOcupado(23, 8); game.setOcupado(23, 9); game.setOcupado(23, 11); game.setOcupado(23, 10); game.setOcupado(23, 11); game.setOcupado(23, 11); game.setOcupado(23, 12); game.setOcupado(23, 13); game.setOcupado(23, 14); game.setOcupado(23, 15); game.setOcupado(15, 11); game.setOcupado(14, 11); game.setOcupado(14, 10); game.setOcupado(15, 10); game.setOcupado(15, 8); game.setOcupado(15, 9); game.setOcupado(14, 9); game.setOcupado(14, 8); game.setOcupado(21, 3); game.setOcupado(20, 3); game.setOcupado(21, 3); game.setOcupado(23, 2); game.setOcupado(22, 2); game.setOcupado(22, 1); game.setOcupado(23, 1); game.setOcupado(23, 0); game.setOcupado(22, 0); game.setOcupado(17, 1); game.setOcupado(18, 1); game.setOcupado(19, 1); game.setOcupado(19, 1); game.setOcupado(19, 1); game.setOcupado(20, 1); game.setOcupado(16, 2); game.setOcupado(15, 2); game.setOcupado(15, 1); game.setOcupado(16, 1); game.setOcupado(16, 0); game.setOcupado(15, 0); game.setOcupado(16, 0);


                        heroiImg = new Bitmap(@"heroi.png");
                        heroi = new ObjHeroi(2, 17, heroiImg);

                        fundo = new Bitmap(@"vila.png");

                        arvoreImg = new Bitmap(@"arvore.png");
                        arvore = new ObjEstatico(0, 3, arvoreImg);
                        game.setOcupado(arvore.X, arvore.Y);

                        Queue<String> msgs = new Queue<string>();
                        msgs.Enqueue("Oh, nobre guerreiro samurai Shingetsu Kun.");
                        msgs.Enqueue("O clan de Glau Xia destruiu tudo nosso.");
                        msgs.Enqueue("Logo antes, antes de sua chegada, eles queimaram toda a vila...");
                        msgs.Enqueue("e... roubaram a sua namorada, a Minna Chan.");
                        msgs.Enqueue("A Glau Xia adora física, logo, só pode ser derrotada por um meio.");
                        msgs.Enqueue("Sei que você quer vingança, mas para recuperar tudo isso, não será necessária a força de um samurai.");
                        msgs.Enqueue("Mas a sabedoria de um matemático.");
                        msgs.Enqueue("...");
                        msgs.Enqueue("Entre no dojo, vamos conseguir sua vingança.");
                        mestreImg = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"heroi.png"));
                        mestre = new ObjNpc(5, 5, mestreImg, msgs);
                        game.setOcupado(mestre.X, mestre.Y);

                        Queue<String> msgsEasterEgg = new Queue<string>();
                        msgsEasterEgg.Enqueue("Easter egg!!!11");
                        easterEggImg = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"heroi.png"));
                        easterEgg = new ObjNpc(5, 5, easterEggImg, msgsEasterEgg);
                        game.setOcupado(mestre.X, mestre.Y);
                    }
                    break;
            }
        }

        public void tick (object sender, EventArgs e)
        {
            switch (fase)
            {
                case 1:
                    {
                        heroi.mover(game);
                    }
                    break;
            }
        }

        public void paint(object sender, PaintEventArgs e)
        {
            switch (fase)
            {
                case 1:
                    {
                        //TODO loop por todas os objetos de ObjGame
                        e.Graphics.DrawImage(fundo, 0, 0, Game.Largura * Game.Tam, Game.Altura * Game.Tam);

                        e.Graphics.DrawImage(heroi.Img, heroi.X * Game.Tam, heroi.Y * Game.Tam, Game.Tam, Game.Tam);
                        e.Graphics.DrawImage(arvore.Img, arvore.X * Game.Tam, arvore.Y * Game.Tam, Game.Tam, Game.Tam);
                        e.Graphics.DrawImage(mestre.Img, mestre.X * Game.Tam, mestre.Y * Game.Tam, Game.Tam, Game.Tam);

                        if (mestre.MostrarTexto)
                        {   //TODO transformar texto p/ classe
                            string text = mestre.Msg;

                            PrivateFontCollection collection = new PrivateFontCollection();
                            collection.AddFontFile(@"fonte.TTF");
                            FontFamily fontFamily = new FontFamily("BankGothic Md BT");

                            using (Font font1 = new Font(fontFamily, 12, FontStyle.Bold, GraphicsUnit.Point))
                            {
                                SizeF a = e.Graphics.MeasureString(text, font1);
                                Size larguraString = a.ToSize();

                                int largura = larguraString.Width;
                                int altura = Game.Tam;
                                int xTxt = (mestre.X * Game.Tam) - largura + Game.Tam;
                                int yTxt = (mestre.Y * Game.Tam) - Game.Tam;

                                while (largura > Game.Tam * Game.Largura / 2)
                                {
                                    largura = largura / 2;
                                    xTxt += largura;
                                    yTxt -= Game.Tam;
                                    altura += Game.Tam;
                                }

                                if (xTxt < 0)
                                {
                                    xTxt = 0;
                                }

                                Rectangle rectF1 = new Rectangle(xTxt, yTxt, largura, altura);
                                SolidBrush branco = new SolidBrush(Color.White);
                                e.Graphics.FillRectangle(branco, rectF1);
                                e.Graphics.DrawString(text, font1, Brushes.Black, rectF1);
                                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectF1));
                            }
                        }
                    }
                    break;
            }
        }

        public void keyDown(object sender, KeyEventArgs e, Label lb)
        {
            switch (fase)
            {
                case 1:
                    {
                        if (e.KeyCode == Keys.Up)
                        {
                            heroi.ActiveUp = true;
                        }

                        if (e.KeyCode == Keys.Down)
                        {
                            heroi.ActiveDown = true;
                        }

                        if (e.KeyCode == Keys.Left)
                        {
                            heroi.ActiveLeft = true;
                        }

                        if (e.KeyCode == Keys.Right)
                        {
                            heroi.ActiveRight = true;
                        }

                        if (e.KeyCode == Keys.E && game.perto(heroi, mestre))
                        {
                            mestre.dialogo(this);
                        }

                        if (e.KeyCode == Keys.Escape)
                        {
                            
                        }

                        if (e.KeyCode == Keys.Space)
                        {
                            lb.Text += "game.setOcupado(" + heroi.X + ", " + heroi.Y + ");\n";
                        }
                    }
                    break;
            }
        }

        public void keyUp (object sender, KeyEventArgs e)
        {
            switch (fase)
            {
                case 1:
                    {
                        if (e.KeyCode == Keys.Up)
                        {
                            heroi.ActiveUp = false;
                        }

                        if (e.KeyCode == Keys.Down)
                        {
                            heroi.ActiveDown = false;
                        }

                        if (e.KeyCode == Keys.Left)
                        {
                            heroi.ActiveLeft = false;
                        }

                        if (e.KeyCode == Keys.Right)
                        {
                            heroi.ActiveRight = false;
                        }
                    }break;
            }
        }
    }

    public class ObjNpc : ObjGame
    {
        private bool mostrarTexto { get; set; }
        private string msg { get; set; }

        private Queue<String> mensagens;

        public ObjNpc(int xN, int yN, Bitmap imgN, Queue<String> mensagensN) : base(xN, yN, imgN)
        {
            mensagens = mensagensN;
        }

        public void dialogo(Background b)
        {
            mostrarTexto = true;
            if (mensagens.Count == 0)
            {
               b.iniciarBatalha();
            }
            else
            {
                msg = mensagens.Dequeue();
            }

        }

        public bool MostrarTexto
        {
            get
            {
                return this.mostrarTexto;
            }

            set
            {
                this.mostrarTexto = value;
            }
        }

        public string Msg
        {
            get
            {
                return this.msg;
            }

            set
            {
                this.msg = value;
            }
        }
    }

    public class ObjEstatico : ObjGame
    {
        public ObjEstatico(int xN, int yN, Bitmap imgN) : base(xN, yN, imgN)
        {
        }
    }

    public class ObjHeroi : ObjGame
    {
        private bool activeLeft { get; set; }
        private bool activeRight { get; set; }
        private bool activeUp { get; set; }
        private bool activeDown { get; set; }

        public bool ActiveDown
        {
            get
            {
                return this.activeDown;
            }
            set
            {
                this.activeDown = value;
            }
        }

        public bool ActiveLeft
        {
            get
            {
                return this.activeLeft;
            }
            set
            {
                this.activeLeft = value;
            }
        }

        public bool ActiveRight
        {
            get
            {
                return this.activeRight;
            }
            set
            {
                this.activeRight = value;
            }
        }

        public bool ActiveUp
        {
            get
            {
                return this.activeUp;
            }
            set
            {
                this.activeUp = value;
            }
        }

        public ObjHeroi(int xN, int yN, Bitmap imgN) : base(xN, yN, imgN)
        {
        }

        public void mover(Game game)
        {
            Thread.Sleep(120);

            if (this.activeUp && game.checkup(this))
            {
                goup();
            }

            if (this.activeDown && game.checkdown(this))
            {
                godown();
            }

            if (this.activeLeft && game.checkleft(this))
            {
                goleft();
            }

            if (this.activeRight && game.checkright(this))
            {
                goright();
            }
        }

        public void goup()
        {
            this.Y -= 1;
        }

        public void godown()
        {
            this.Y += 1;
        }

        public void goleft()
        {
            this.X -= 1;
        }

        public void goright()
        {
            this.X += 1;
        }
    }

    public class ObjGame
    {
        private int x { get; set; }
        private int y { get; set; }
        private Bitmap img { get; set; }

        public ObjGame(int xN, int yN, Bitmap imgN)
        {
            this.x = xN;
            this.y = yN;
            this.img = imgN;
        }

        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        public Bitmap Img
        {
            get
            {
                return this.img;
            }

            set
            {
                this.img = value;
            }
        }
    }

    public class Game
    {
        private bool[][] grid = new bool[25][];//25x20
        public const int Tam = 32, Altura = 20, Largura = 25, Speed = 1;

        public Game()
        {
            for (int i = 0; i < Largura; i++)
            {
                grid[i] = new bool[20];
                for (int j = 0; j < Altura; j++)
                {
                    grid[i][j] = true;
                }
            }
        }

        public bool perto(ObjGame obj1, ObjGame obj2)
        {
            if ((obj1.X == (obj2.X - 1) && obj1.Y == obj2.Y) ||//y igual a esquerda
                (obj1.X == (obj2.X + 1) && obj1.Y == obj2.Y) ||//y igual a direita
                (obj1.Y == (obj2.Y - 1) && obj1.X == obj2.X) ||//x igual a abaixo
                (obj1.Y == (obj2.Y + 1) && obj1.X == obj2.X))   //x igual acima
            {
                return true;
            }

            return false;
        }

        public void setOcupado(int xNovo, int yNovo)
        {
            if (xNovo < 0 && xNovo > Largura)
            {
                //throw exception
            }

            if (yNovo < 0 && yNovo > Altura)
            {
                //throw exception
            }

            grid[xNovo][yNovo] = false;
        }

        public void setLivre(int xNovo, int yNovo)
        {
            if (xNovo < 0 && xNovo > Largura)
            {
                //throw exception
            }

            if (yNovo < 0 && yNovo > Altura)
            {
                //throw exception
            }

            grid[xNovo][yNovo] = true;
        }

        public bool checkup(ObjGame obj)
        {
            if (obj.Y == 0)
                return false;

            return grid[obj.X][obj.Y - 1];
        }

        public bool checkdown(ObjGame obj)
        {
            if (obj.Y == Altura - 1)
                return false;

            return grid[obj.X][obj.Y + 1];
        }

        public bool checkleft(ObjGame obj)
        {
            if (obj.X == 0)
                return false;

            return grid[obj.X - 1][obj.Y];
        }

        public bool checkright(ObjGame obj)
        {
            if (obj.X == Largura - 1)
                return false;

            return grid[obj.X + 1][obj.Y];
        }


    }
}