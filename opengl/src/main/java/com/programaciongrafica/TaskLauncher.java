package com.programaciongrafica;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.GridLayout;
import javax.swing.BorderFactory;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.SwingConstants;
import javax.swing.SwingUtilities;
import javax.swing.UIManager;

/**
 * Ventana simple para ejecutar las practicas disponibles.
 */
public class TaskLauncher {

    public static void main(String[] args) {
        SwingUtilities.invokeLater(TaskLauncher::showLauncher);
    }

    private static void showLauncher() {
        setSystemLookAndFeel();

        JFrame frame = new JFrame("Lanzador de tareas");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLayout(new BorderLayout(12, 12));

        JLabel title = new JLabel("Selecciona una tarea para ejecutar", SwingConstants.CENTER);
        title.setBorder(BorderFactory.createEmptyBorder(16, 16, 0, 16));

        JButton helloWorldButton = new JButton("Hello World");
        helloWorldButton.addActionListener(event -> HelloWorldApp.main(new String[0]));

        JButton squareButton = new JButton("Cuadrado OpenGL");
        squareButton.addActionListener(event -> {
            Thread appThread = new Thread(() -> App.main(new String[0]), "opengl-app-thread");
            appThread.setDaemon(false);
            appThread.start();
        });

        JPanel buttons = new JPanel(new GridLayout(2, 1, 12, 12));
        buttons.setBorder(BorderFactory.createEmptyBorder(0, 24, 24, 24));
        buttons.add(helloWorldButton);
        buttons.add(squareButton);

        frame.add(title, BorderLayout.NORTH);
        frame.add(buttons, BorderLayout.CENTER);
        frame.setMinimumSize(new Dimension(360, 220));
        frame.pack();
        frame.setLocationRelativeTo(null);
        frame.setVisible(true);
    }

    private static void setSystemLookAndFeel() {
        try {
            UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
        } catch (Exception ignored) {
            // Si falla, Swing usara el tema por defecto.
        }
    }
}
