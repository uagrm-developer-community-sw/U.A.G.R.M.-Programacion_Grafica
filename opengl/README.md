# OpenGL Maven Project

Proyecto base en Java usando **Maven** y **LWJGL (OpenGL)**.

## Estructura sugerida

- `pom.xml` - configuración de Maven y dependencias.
- `src/main/java` - código Java.
- `src/test/java` - pruebas (opcional).

## Ejecutar

1. Compilar:

```bash
mvn clean package
```

2. Ejecutar (usa el main de `com.programaciongrafica.App`):

```bash
mvn exec:java
```

> Si tu sistema no es Linux, actualiza el valor de `lwjgl.natives` en `pom.xml` a `natives-windows` o `natives-macos`.
