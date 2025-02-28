# ✈️ **Aire Tour - Simulador de Tiquetes de Avión** 🌍

## 🚀 Descripción

**Simulador de Tiquetes de Aire Tour** Esta aplicación ha sido desarrollada utilizando **C#** con **Windows Forms**, y tiene como objetivo calcular el valor a pagar por un tiquete de avión según varios factores, como el destino, la clase del vuelo, el estrato socioeconómico del cliente, el día de la semana y el género del pasajero. 

El simulador realiza el cálculo de manera dinámica y presenta un reporte con todos los detalles de la compra del tiquete.

### 📋 Requisitos
- **Lenguaje:** C#
- **Interfaz:** Windows Forms
- **Función:** Calcular el valor del tiquete de avión, aplicar descuentos y mostrar un reporte detallado.

## 🛫 Funcionalidades

- **Pantalla de inicio** con un formulario de acceso protegido por contraseña.
- **Interfaz de Aire Tour** para ingresar los datos del cliente (número de identificación, nombre completo, destino, clase de vuelo, estrato, género y día de la semana).
- **Cálculos de descuentos** basados en:
  - El estrato socioeconómico.
  - El día de la semana del vuelo.
  - Un descuento adicional para el género femenino.
- **Formulario de reporte** que muestra los detalles del cliente, incluyendo el cálculo del valor a pagar por el tiquete.

## 📝 Tablas para Cálculos

### 💼 **Valores por Trayecto**

| Destino   | Clase A   | Clase B   | Clase C   |
|-----------|-----------|-----------|-----------|
| Bogotá    | $300,000  | $225,000  | $150,000  |
| Medellín  | $420,000  | $315,000  | $210,000  |
| Florencia | $270,000  | $202,500  | $135,000  |
| Pitalito  | $250,000  | $187,500  | $125,000  |

### 💸 **Descuentos por Estrato Socioeconómico**

| Estrato | Descuento |
|---------|-----------|
| 1       | 10%       |
| 2       | 10%       |
| 3       | 7%        |
| 4       | 7%        |
| 5       | 5%        |
| 6       | 5%        |

### 📅 **Descuentos por Día de la Semana**

| Día       | Descuento |
|-----------|-----------|
| Lunes     | 10%       |
| Martes    | 10%       |
| Miércoles | 10%       |
| Jueves    | 5%        |
| Viernes   | 5%        |
| Sábado    | 0%        |
| Domingo   | 0%        |

### 👩‍🦰 **Descuento por Género**

- La **aerolínea Aire Tour** ofrece un descuento adicional del **3%** para las pasajeras femeninas.

## 🖥️ Funcionalidad de la Aplicación

1. **Pantalla de Inicio:**
   - Muestra el nombre completo del autor de la aplicación, el nombre de la aplicación (**Aire Tour**) y un nivel de seguridad básico con una contraseña enmascarada (**`123`**).
   
2. **Formulario de Ingreso de Datos:**
   - Al ingresar la contraseña correctamente, se redirige a un formulario donde se capturan los datos del cliente.
   - Los campos incluyen: número de identificación, nombre completo, destino, clase de vuelo, estrato, género y día de la semana.

3. **Cálculo del Tiquete:**
   - El valor del tiquete se calcula según las tablas proporcionadas y se aplican los descuentos correspondientes.
   - El campo donde se muestra el valor total a pagar está deshabilitado para que el usuario no lo edite directamente.

4. **Formulario de Reporte:**
   - Al hacer clic en **Calcular**, se muestra un formulario de reporte con toda la información del cliente y el cálculo del valor a pagar por el tiquete de avión.
   - El reporte incluye todos los datos ingresados y los descuentos aplicados.

5. **Botones del Formulario de Aire Tour:**
   - **Registrar:** Guarda los datos del cliente.
   - **Calcular:** Muestra el reporte con los resultados.
   - **Salir:** Pide confirmación para salir de la aplicación.

6. **Filtros de Validación:**
   - Se verifica que todos los campos sean obligatorios y que los valores numéricos no contengan letras o caracteres no válidos.
   
7. **Diseño Personalizado:**
   - Cada formulario tiene un color de fondo diferente y un logo de la aplicación.
   - El diseño es completamente personalizable, evitando el uso de imágenes de fondo para mantener el peso del archivo bajo.
