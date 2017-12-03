using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1
{
    public class LinkedList : LinkedListADT
    {
        public override void InsertFirst(Musteri value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }

        public override void InsertLast(Musteri value)
        {
            Node oldLast = Head;

            if (Head == null)
                InsertFirst(value);
            else
            {
                Node newLast = new Node
                {
                    Data = value
                };
                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }
                oldLast.Next = newLast;
                Size++;
            }
        }

        public override void InsertPos(int position, Musteri value)
        {
            Node newNode = new Node { Data = value };
            Node nextNode = null;

            int count = 0;
            Node tempNode = Head;
            while (tempNode != null)
            {
                if (count == position)
                {
                    nextNode = tempNode.Next;
                    tempNode.Next = newNode;
                    newNode.Next = nextNode;
                    break;
                }
                tempNode = tempNode.Next;
                count++;

            }
            Size++;

        }

        public override void DeleteFirst()
        {
            if (Head != null)
            {
                Node tempHeadNext = this.Head.Next;
                if (tempHeadNext == null)
                    Head = null;
                else
                    Head = tempHeadNext;
                Size--;
            }
        }

        public override void DeleteLast()
        {
            Node lastNode = Head;
            Node lastPrevNode = null;
            while (true)
            {
                if (lastNode.Next != null)
                {
                    lastPrevNode = lastNode;
                    lastNode = lastNode.Next;
                }
                else
                    break;
            }
            Size--;
            lastNode = null;
            if (lastPrevNode != null)
                lastPrevNode.Next = null;
            else
                Head = null;
        }

        public override void DeletePos(int position)
        {
            Node silinecekNode = Head;
            Node prevNode = null;
            int count = 0;
            while (silinecekNode != null)
            {

                if (count == position)
                {
                    if (silinecekNode.Next==Head.Next)
                    {
                        DeleteFirst();
                        Size++;
                        break;

                    }
                    else
                    {
                        prevNode.Next = silinecekNode.Next;
                        break;
                    }
                    
                }
                else if (silinecekNode.Next != null)
                {
                    prevNode = silinecekNode;
                    silinecekNode = silinecekNode.Next;
                }
                count++;
            }
            Size--;
        }

        public override string GetElement(String ad, string soyad)
        {
            string mesaj = "";
            Node retNode = null;
            Node tempNode = Head;
            bool bulundumu = false;           
            while (tempNode != null)
            {
                if (tempNode.Data.Ad==ad && tempNode.Data.Soyad==soyad)
                {
                    retNode = tempNode;
                    bulundumu = true;
                    break;
                }
                tempNode = tempNode.Next;
                
            }
            if (bulundumu==false)
            {
               return "Lütfen Ad Soyad Kısmını Doğtu Giriniz!";

            }
            mesaj = retNode.Data.KoltukNo.ToString()+" .Koltuk";
            return mesaj;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data.KoltukNo.ToString();
                item = item.Next;
            }

            return temp;
        }

        public string BiletIptal(int KoltukNo)
        {
            int i = 1;
            bool Bulundumu = false;
            Node temp = Head;
                                   
                while (temp != null)
                {
                    if (temp.Data.KoltukNo == KoltukNo)
                    {
                        DeletePos(i - 1);
                        Bulundumu = true;
                        break;
                    }
                    i++;
                    if (temp.Next != null)
                        temp = temp.Next;
                    else
                        break;
                }
            if (Bulundumu)
            {
                return KoltukNo.ToString() + " Numaralı koltuğun bileti iptal edildi";
            }
            else
            {
                return KoltukNo.ToString() + " Numaralı koltuk bulunamadı";
            }
            
        }

        public string BiletAl(int KoltukNo, string MusteriAd, string MusteriSoyad)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = MusteriAd;
            musteri.Soyad = MusteriSoyad;
            musteri.KoltukNo = KoltukNo;
            Node temp = Head;
            Node gecici = Head;
            bool eklendimi = false;
            int i = 0;
            while (gecici!=null)
            {
                if (KoltukNo==gecici.Data.KoltukNo)
                {
                    return KoltukNo.ToString() + " Numaralı koltuk daha önceden alınmıştır lütfen başka bir koltuk seçin.";
                }
                if (gecici.Next != null)
                {
                    gecici = gecici.Next;
                }
                else
                    break;
            }

            if (Head == null)
            {
                InsertFirst(musteri);
            }
            else
            {
                while (temp != null)
                {
                    if (Head.Data.KoltukNo > musteri.KoltukNo)
                    {
                        InsertFirst(musteri);
                        eklendimi = true;
                        break;
                    }
                    if (temp.Data.KoltukNo > musteri.KoltukNo)
                    {
                        InsertPos(i - 1, musteri);
                        eklendimi = true;
                        break;

                    }
                    i++;
                    if (temp.Next != null)
                    {
                        temp = temp.Next;
                    }

                    else
                        break;

                }
                if (eklendimi == false)
                {
                    InsertLast(musteri);
                    eklendimi = true;
                }
            }
            return KoltukNo.ToString() + " Numaralı koltuğun bileti alındı.";
        }

        public string BosKoltuklariListele(List <int> BosKoltuklar)
        {
            string mesaj = "";
            for (int i = 1; i < 61; i++)
            {
                BosKoltuklar.Add(i);
            }

            Node temp = Head;
            int j = 0;
            while (temp != null)
            {
                BosKoltuklar.Remove(temp.Data.KoltukNo);
                if (temp.Next != null)
                    temp = temp.Next;
                else
                    break;
                j++;
            }
            foreach (int i in BosKoltuklar)
            {
                if (i%2==0)
                    mesaj += i.ToString() + ". Koltuk"+Environment.NewLine;
                else
                    mesaj += i.ToString() + ". Koltuk     ";

            }

            return mesaj;
           
           
        }
        public string DoluKoltuklariListele()
        {
            string mesaj = "";
            Node temp =Head;
            int i = 0;
            while (temp != null)
            {
                if (i%2==0)
                    mesaj += temp.Data.KoltukNo.ToString() + ". Koltuk" + Environment.NewLine;
                else
                    mesaj += temp.Data.KoltukNo.ToString() + ". Koltuk     ";

                i++;

                if (temp.Next != null)
                    temp = temp.Next;
                else
                    break;
            }
            
            return mesaj;

        }
       
        
    }

}

