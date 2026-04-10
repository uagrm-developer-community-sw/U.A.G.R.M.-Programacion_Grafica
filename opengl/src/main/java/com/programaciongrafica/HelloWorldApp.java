package com.programaciongrafica;

import javax.swing.JOptionPane;
import javax.swing.SwingUtilities;

/**
 * Ejemplo basico para validar el entorno Java.
 */
public class HelloWorldApp {

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            String message = "Hola Mundo desde Java + Maven + VS Code";
            System.out.println(message);
            JOptionPane.showMessageDialog(null, message, "Hello World", JOptionPane.INFORMATION_MESSAGE);
        });
    }
}
