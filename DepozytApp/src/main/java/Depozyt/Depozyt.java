package Depozyt;

import Depozyt.Przedmioty;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.List;
import org.hibernate.Session;
import org.hibernate.Transaction;

import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.PDPageContentStream;
import org.apache.pdfbox.pdmodel.common.PDRectangle;
import org.apache.pdfbox.pdmodel.font.PDType1Font;

import java.io.IOException;

public class Depozyt extends JFrame {
    private JButton nowyButton;
    private JButton przedluzenieButton;
    private JButton usunButton;
    private JButton wyswietlDepozytyButton;
    private JPanel mainPanel;
    private CardLayout cardLayout;

    public Depozyt() {
        setTitle("Depozyt - Zarządzanie");
        setSize(800, 600);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        //setResizable(false);


        mainPanel = new JPanel();
        cardLayout = new CardLayout();
        mainPanel.setLayout(cardLayout);


        mainPanel.add(createNowyPanel(), "Nowy");
        mainPanel.add(createWyszukaniePanel(), "Wyszukanie");
        mainPanel.add(createUsunPanel(), "Usun");
        mainPanel.add(createWyswietlDepozytyPanel(), "WyswietlDepozyty");


        JPanel menuPanel = new JPanel();
        menuPanel.setLayout(new GridBagLayout());

        nowyButton = new JButton("Nowy");
        przedluzenieButton = new JButton("Szukaj");
        usunButton = new JButton("Usuń");
        wyswietlDepozytyButton = new JButton("Wyświetl depozyty");


        nowyButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                cardLayout.show(mainPanel, "Nowy");
            }
        });

        przedluzenieButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                cardLayout.show(mainPanel, "Wyszukanie");
            }
        });

        usunButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                cardLayout.show(mainPanel, "Usun");
            }
        });

        wyswietlDepozytyButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                cardLayout.show(mainPanel, "WyswietlDepozyty");
            }
        });

        // Dodawanie przycisków do panelu menu z wyrównaniem i szerokością
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = GridBagConstraints.RELATIVE;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.weightx = 1;
        gbc.anchor = GridBagConstraints.NORTH;

        menuPanel.add(nowyButton, gbc);
        menuPanel.add(przedluzenieButton, gbc);
        menuPanel.add(usunButton, gbc);
        menuPanel.add(wyswietlDepozytyButton, gbc);

        gbc.weighty = 1;
        menuPanel.add(Box.createVerticalGlue(), gbc);


        getContentPane().setLayout(new BorderLayout());
        getContentPane().add(menuPanel, BorderLayout.WEST);
        getContentPane().add(mainPanel, BorderLayout.CENTER);
    }


    private JPanel createNowyPanel() {
        JPanel panel = new JPanel();
        panel.setLayout(new GridBagLayout());

        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        //JLabel idLabel = new JLabel("ID:");
        //JTextField idField = new JTextField(20);
        JLabel dataLabel = new JLabel("Data:");
        JTextField dataField = new JTextField(20);
        JLabel telefonLabel = new JLabel("Telefon:");
        JTextField telefonField = new JTextField(20);
        JLabel imieLabel = new JLabel("Imię:");
        JTextField imieField = new JTextField(20);
        JLabel nazwiskoLabel = new JLabel("Nazwisko:");
        JTextField nazwiskoField = new JTextField(20);
        JLabel firmaLabel = new JLabel("Firma:");
        JTextField firmaField = new JTextField(20);
        JLabel rodzajLabel = new JLabel("Rodzaj depozytu:");
        JTextField rodzajField = new JTextField(20);
        JLabel iloscLabel = new JLabel("Ilosc:");
        JTextField iloscField = new JTextField(20);
        JLabel rozmiarLabel = new JLabel("Rozmiar:");
        JTextField rozmiarField = new JTextField(20);
        JLabel markaLabel = new JLabel("Marka:");
        JTextField markaField = new JTextField(20);
        JLabel rodzajfelglabel = new JLabel("Rodzaj felg:");
        JTextField rodzajfelgField = new JTextField(20);
        JLabel uwagiLabel = new JLabel("Uwagi:");
        JTextField uwagiField = new JTextField(20);


        gbc.gridx = 0;
        gbc.gridy = 1;
        panel.add(dataLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 1;
        panel.add(dataField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 2;
        panel.add(telefonLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 2;
        panel.add(telefonField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 3;
        panel.add(imieLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 3;
        panel.add(imieField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 4;
        panel.add(nazwiskoLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 4;
        panel.add(nazwiskoField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 5;
        panel.add(firmaLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 5;
        panel.add(firmaField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 6;
        panel.add(rodzajLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 6;
        panel.add(rodzajField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 7;
        panel.add(iloscLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 7;
        panel.add(iloscField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 8;
        panel.add(rozmiarLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 8;
        panel.add(rozmiarField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 9;
        panel.add(markaLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 9;
        panel.add(markaField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 10;
        panel.add(rodzajfelglabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 10;
        panel.add(rodzajfelgField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 11;
        panel.add(uwagiLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 11;
        panel.add(uwagiField, gbc);

        JButton saveButton = new JButton("Zapisz");
        gbc.gridx = 0;
        gbc.gridy = 12;
        gbc.gridwidth = 2;
        panel.add(saveButton, gbc);


        saveButton.addActionListener(e -> {

            int id = 1; //Integer.parseInt(idField.getText());
            String data = dataField.getText();
            String telefon = telefonField.getText();
            String imie = imieField.getText();
            String nazwisko = nazwiskoField.getText();
            String firma = firmaField.getText();
            String rodzaj = rodzajField.getText();
            int ilosc = Integer.parseInt(iloscField.getText());
            String rozmiar = rozmiarField.getText();
            String marka = markaField.getText();
            String rodzajFelg = rodzajfelgField.getText();
            String uwagi = uwagiField.getText();


            Przedmioty nowyPrzedmiot = new Przedmioty(id, telefon, data, imie, nazwisko, firma, rodzaj, ilosc, rozmiar, marka, rodzajFelg, uwagi);


            Session session = HibernateUtil.getSessionFactory().openSession();
            Transaction transaction = null;
            try {
                transaction = session.beginTransaction();
                session.save(nowyPrzedmiot);
                transaction.commit();
                JOptionPane.showMessageDialog(null, "Dane zapisane do bazy danych!", "Sukces", JOptionPane.INFORMATION_MESSAGE);
            } catch (Exception ex) {
                if (transaction != null) {
                    transaction.rollback();
                }
                JOptionPane.showMessageDialog(null, "Błąd podczas zapisywania danych do bazy danych!", "Błąd", JOptionPane.ERROR_MESSAGE);
                ex.printStackTrace();
            } finally {
                session.close();
            }
        });

        return panel;
    }





    private JPanel createWyszukaniePanel() {
        JPanel panel = new JPanel(new GridBagLayout());

        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        JLabel cechaLabel = new JLabel("Wybierz cechę:");
        JComboBox<String> cechaComboBox = new JComboBox<>(new String[]{"Data", "Telefon", "Imie", "Nazwisko", "Firma", "Rodzaj_dep", "Ilosc", "Rozmiar", "Marka", "Rodzaj_felg", "Uwagi"});
        JLabel wartoscLabel = new JLabel("Wprowadź wartość:");
        JTextField wartoscField = new JTextField(20);
        JButton szukajButton = new JButton("Szukaj");
        JTextArea textArea = new JTextArea(10, 40);
        textArea.setEditable(false);
        JScrollPane scrollPane = new JScrollPane(textArea);
        scrollPane.setVerticalScrollBarPolicy(JScrollPane.VERTICAL_SCROLLBAR_ALWAYS);


        gbc.gridx = 0;
        gbc.gridy = 0;
        panel.add(cechaLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 0;
        panel.add(cechaComboBox, gbc);

        gbc.gridx = 0;
        gbc.gridy = 1;
        panel.add(wartoscLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 1;
        panel.add(wartoscField, gbc);

        gbc.gridx = 0;
        gbc.gridy = 2;
        gbc.gridwidth = 2;
        panel.add(szukajButton, gbc);

        gbc.gridx = 0;
        gbc.gridy = 3;
        gbc.gridwidth = 2;
        panel.add(scrollPane, gbc);


        szukajButton.addActionListener(e -> {
            String wybranaCecha = (String) cechaComboBox.getSelectedItem();
            String wartosc = wartoscField.getText();
            Session session = HibernateUtil.getSessionFactory().openSession();
            try {
                String query = "from Przedmioty where " + wybranaCecha.toLowerCase() + " = :wartosc";
                List<Przedmioty> przedmioty = session.createQuery(query, Przedmioty.class)
                        .setParameter("wartosc", wartosc)
                        .list();
                textArea.setText("");
                if (!przedmioty.isEmpty()) {
                    for (Przedmioty przedmiot : przedmioty) {
                        textArea.append(przedmiot.toString() + "\n");
                    }
                } else {
                    textArea.setText("Nie znaleziono depozytu o podanej wartości.");
                }
            } catch (Exception ex) {
                ex.printStackTrace();
                JOptionPane.showMessageDialog(this, "Wystąpił błąd podczas wyszukiwania danych", "Błąd", JOptionPane.ERROR_MESSAGE);
            } finally {
                session.close();
            }
        });

        return panel;
    }

    private JPanel createUsunPanel() {
        JPanel panel = new JPanel(new GridBagLayout());

        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(5, 5, 5, 5);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        JLabel idLabel = new JLabel("ID do usunięcia:");
        JTextField idField = new JTextField(20);

        gbc.gridx = 0;
        gbc.gridy = 0;
        panel.add(idLabel, gbc);

        gbc.gridx = 1;
        gbc.gridy = 0;
        panel.add(idField, gbc);

        JButton usunButton = new JButton("Usuń");
        gbc.gridx = 0;
        gbc.gridy = 1;
        gbc.gridwidth = 2;
        panel.add(usunButton, gbc);

        usunButton.addActionListener(e -> {

            int idToDelete = Integer.parseInt(idField.getText().trim());


            SwingUtilities.invokeLater(() -> {
                Session session = HibernateUtil.getSessionFactory().openSession();
                Transaction transaction = null;
                try {
                    transaction = session.beginTransaction();
                    Przedmioty przedmiotDoUsuniecia = session.get(Przedmioty.class, idToDelete);
                    if (przedmiotDoUsuniecia != null) {
                        session.delete(przedmiotDoUsuniecia);
                        transaction.commit();
                        JOptionPane.showMessageDialog(null, "Rekord został pomyślnie usunięty!", "Sukces", JOptionPane.INFORMATION_MESSAGE);
                    } else {
                        JOptionPane.showMessageDialog(null, "Nie znaleziono rekordu o podanym ID!", "Błąd", JOptionPane.ERROR_MESSAGE);
                    }
                } catch (NumberFormatException ex) {
                    JOptionPane.showMessageDialog(null, "Podano nieprawidłowy format ID!", "Błąd", JOptionPane.ERROR_MESSAGE);
                } catch (Exception ex) {
                    if (transaction != null) {
                        transaction.rollback();
                    }
                    JOptionPane.showMessageDialog(null, "Błąd podczas usuwania rekordu!", "Błąd", JOptionPane.ERROR_MESSAGE);
                    ex.printStackTrace();
                } finally {
                    session.close();
                }
            });
        });

        return panel;
    }

    private JPanel createWyswietlDepozytyPanel() {
        JPanel panel = new JPanel(new BorderLayout());

        JTextArea textArea = new JTextArea();
        textArea.setEditable(false);

        JScrollPane scrollPane = new JScrollPane(textArea);
        scrollPane.setVerticalScrollBarPolicy(JScrollPane.VERTICAL_SCROLLBAR_ALWAYS);
        panel.add(scrollPane, BorderLayout.CENTER);

        JButton refreshButton = new JButton("Odśwież");
        refreshButton.addActionListener(e -> {

            textArea.setText("");


            Session session = HibernateUtil.getSessionFactory().openSession();
            try {
                List<Przedmioty> przedmiotyList = session.createQuery("FROM Przedmioty", Przedmioty.class).getResultList();
                for (Przedmioty przedmiot : przedmiotyList) {
                    textArea.append(przedmiot.toString() + "\n\n");
                }
            } catch (Exception ex) {
                ex.printStackTrace();
                JOptionPane.showMessageDialog(null, "Błąd podczas pobierania danych z bazy danych!", "Błąd", JOptionPane.ERROR_MESSAGE);
            } finally {
                session.close();
            }
        });
        panel.add(refreshButton, BorderLayout.SOUTH);
        refreshButton.doClick();

        return panel;
    }


    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            @Override
            public void run() {
                new Depozyt().setVisible(true);
            }
        });
    }

    {
// GUI initializer generated by IntelliJ IDEA GUI Designer
// >>> IMPORTANT!! <<<
// DO NOT EDIT OR ADD ANY CODE HERE!
        $$$setupUI$$$();
    }

    /**
     * Method generated by IntelliJ IDEA GUI Designer
     * >>> IMPORTANT!! <<<
     * DO NOT edit this method OR call it in your code!
     *
     * @noinspection ALL
     */
    private void $$$setupUI$$$() {
        final JPanel panel1 = new JPanel();
        panel1.setLayout(new GridBagLayout());
        przedluzenieButton = new JButton();
        przedluzenieButton.setText("Przedłużenie depozytu");
        GridBagConstraints gbc;
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 2;
        gbc.weighty = 1.0;
        panel1.add(przedluzenieButton, gbc);
        usunButton = new JButton();
        usunButton.setText("Usuń depozyt");
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 3;
        gbc.weighty = 1.0;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        panel1.add(usunButton, gbc);
        wyswietlDepozytyButton = new JButton();
        wyswietlDepozytyButton.setText("Wyświetl depozyty");
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 4;
        gbc.weighty = 1.0;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        panel1.add(wyswietlDepozytyButton, gbc);
        nowyButton = new JButton();
        nowyButton.setText("Nowy depozyt");
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 1;
        gbc.weighty = 1.0;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        panel1.add(nowyButton, gbc);
        final JPanel spacer1 = new JPanel();
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.weighty = 5.0;
        gbc.fill = GridBagConstraints.VERTICAL;
        panel1.add(spacer1, gbc);
        final JPanel spacer2 = new JPanel();
        gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 5;
        gbc.weighty = 5.0;
        gbc.fill = GridBagConstraints.VERTICAL;
        panel1.add(spacer2, gbc);
        final JPanel panel2 = new JPanel();
        panel2.setLayout(new GridBagLayout());
        gbc = new GridBagConstraints();
        gbc.gridx = 1;
        gbc.gridy = 0;
        gbc.gridheight = 6;
        gbc.weightx = 7.0;
        gbc.fill = GridBagConstraints.BOTH;
        panel1.add(panel2, gbc);
    }
}
