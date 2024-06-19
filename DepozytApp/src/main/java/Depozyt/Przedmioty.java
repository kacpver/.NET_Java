package Depozyt;

import org.hibernate.annotations.GenericGenerator;
import javax.persistence.*;
import java.util.Date;

@Entity
@Table(name = "Przedmioty")
public class Przedmioty {
    @Id
    @GeneratedValue(strategy = GenerationType.SEQUENCE, generator = "smallestAvailableIdGenerator")
    @GenericGenerator(name = "smallestAvailableIdGenerator", strategy = "Depozyt.SmallestAvailableIdGenerator")
    @Column(name = "id")
    private int Id;

    @Column(name = "telefon")
    private String Telefon;

    @Column(name = "data")
    private String Data;

    @Column(name = "imie")
    private String Imie;

    @Column(name = "nazwisko")
    private String Nazwisko;

    @Column(name = "firma")
    private String Firma;

    @Column(name = "rodzaj_dep")
    private String Rodzaj_dep;

    @Column(name = "ilosc")
    private int Ilosc;

    @Column(name = "rozmiar")
    private String Rozmiar;

    @Column(name = "marka")
    private String Marka;

    @Column(name = "rodzaj_felg")
    private String Rodzaj_felg;

    @Column(name = "uwagi")
    private String Uwagi;

    public Przedmioty() {}

    public Przedmioty(int id, String telefon, String data, String imie, String nazwisko, String firma, String rodzajDep, int ilosc, String rozmiar, String marka, String rodzaj_felg, String uwagi) {
        this.Id = id;
        this.Telefon = telefon;
        this.Data = data;
        this.Imie = imie;
        this.Nazwisko = nazwisko;
        this.Firma = firma;
        this.Rodzaj_dep = rodzajDep;
        this.Ilosc = ilosc;
        this.Rozmiar = rozmiar;
        this.Marka = marka;
        this.Rodzaj_felg = rodzaj_felg;
        this.Uwagi = uwagi;
    }

    public int getId() { return Id; }
    public String getData() { return Data; }
    public String getTelefon() { return Telefon; }
    public String getImie() { return Imie; }
    public String getNazwisko() { return Nazwisko; }
    public String getFirma() { return Firma; }
    public String getRodzaj_dep() { return Rodzaj_dep; }
    public int getIlosc() { return Ilosc; }
    public String getRozmiar() { return Rozmiar; }
    public String getMarka() { return Marka; }
    public String getRodzaj_felg() { return Rodzaj_felg; }
    public String getUwagi() { return Uwagi; }
    public void setId(int id) { Id = id; }
    public void setData(String data) { Data = data; }
    public void setTelefon(String telefon) { Telefon = telefon; }
    public void setImie(String imie) { Imie = imie; }
    public void setNazwisko(String nazwisko) { Nazwisko = nazwisko; }
    public void setFirma(String firma) { Firma = firma; }
    public void setRodzaj_dep(String rodzaj_dep) { Rodzaj_dep = rodzaj_dep; }
    public void setIlosc(int ilosc) { Ilosc = ilosc; }
    public void setRozmiar(String rozmiar) { Rozmiar = rozmiar; }
    public void setMarka(String marka) { Marka = marka; }
    public void setRodzaj_felg(String rodzaj_felg) { Rodzaj_felg = rodzaj_felg; }
    public void setUwagi(String uwagi) { Uwagi = uwagi; }

    @Override
    public String toString() {
        return "ID: " + Id + "\n" +
                "Data: " + Data +
                " Telefon: " + Telefon +
                " Imię: " + Imie +
                " Nazwisko: " + Nazwisko +
                " Firma: " + Firma + "\n" +
                "Rodzaj depozytu: " + Rodzaj_dep +
                " Ilość: " + Ilosc +
                " Rozmiar: " + Rozmiar +
                " Marka: " + Marka +
                " Rodzaj felg: " + Rodzaj_felg + "\n" +
                "Uwagi: " + Uwagi;
    }
}
