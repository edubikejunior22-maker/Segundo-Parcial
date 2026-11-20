# Sistema de Alquiler de Vehículos 

## 1. Datos del Estudiante y Asignatura
* **Nombre:** Pedro Yunior Edubique Hernandez
* **Matrícula:** [2025-1422]
* **Asignatura:** Programación Básica
* **Evaluación:** Segundo Parcial
* **Profesor:** Gamalier Reyes del Carmen

---

## 2. Descripción del Programa
Aplicación de escritorio desarrollada en **C# (Windows Forms)** que permite gestionar y calcular cotizaciones para el alquiler de vehículos. El sistema permite registrar múltiples vehículos en una misma orden, aplicar cargos por coberturas y accesorios opcionales, gestionar descuentos para clientes corporativos, calcular costos de entrega a domicilio y desglosar el impuesto correspondiente (ITBIS).

---

## 3. Datos de Entrada
Para operar el sistema, el usuario debe ingresar los siguientes datos a través de la interfaz gráfica:

* **Datos del Cliente y Orden:**
  * **Nombre del cliente:** Texto ingresado en `txtCliente`.
  * **Fecha de salida:** Fecha seleccionada en `dtpSalida`.
  * **Tipo de cliente:** Selección de cliente corporativo mediante la casilla `chkCorporativo`.
  * **Tipo de entrega:** Selección entre entrega en sucursal (`rbtSucursal`) o entrega a domicilio (`rbtDomicilio`).
* **Datos del Vehículo (por cada registro):**
  * **Descripción del vehículo:** Nombre o modelo ingresado en `txtVehiculo`.
  * **Tarifa diaria:** Monto numérico base ingresado en `txtTarifa`.
  * **Cantidad de días:** Valor numérico entre 1 y 30 seleccionado en `nudDias`.
  * **Tipo de cobertura:** Selección entre seguro básico (`rbtBasico`) o seguro completo (`rbtCompleto`).
  * **Servicio adicional:** Selección opcional de GPS mediante `chkGps`.

---

## 4. Proceso
El programa ejecuta las siguientes validaciones y cálculos matemáticos:

1. **Validación de Campos:** Verifica que el nombre del vehículo no esté vacío, que la tarifa diaria sea un número válido y que exista al menos un vehículo en la lista antes de calcular el total.
2. **Cálculo de Tarifa Diaria Ajustada:**
   * Si se selecciona **Seguro Completo**, se suman **RD$ 300.00** a la tarifa diaria.
   * Si se selecciona **GPS**, se suman **RD$ 100.00** a la tarifa diaria.
3. **Cálculo por Línea y Subtotal:**
   * `Importe de Línea = Tarifa Diaria Ajustada × Cantidad de Días`
   * `Subtotal = Sumatoria de todos los importes agregados a la lista`
4. **Cálculo de Descuentos, Cargos e Impuestos:**
   * **Descuento Corporativo:** Si está marcado, se calcula el **15%** sobre el subtotal (`Subtotal × 0.15`).
   * **Cargo a Domicilio:** Si se elige entrega a domicilio, se suman **RD$ 500.00**; en sucursal es **RD$ 0.00**.
   * **Monto Gravable:** `(Subtotal - Descuento) + Cargo a Domicilio`
   * **ITBIS (18%):** `Monto Gravable × 0.18`
   * **Total General:** `Monto Gravable + ITBIS`

---

## 5. Salida
El sistema muestra los resultados en pantalla mediante los siguientes controles:

* **Listado Detallado (`lstAlquileres`):** Muestra cada vehículo agregado con formato tabular alineado (Días, Descripción con extras, Tarifa diaria ajustada e Importe total de la línea).
* **Resumen Financiero (Etiquetas de texto formateadas en moneda `RD$`):**
  * **Subtotal (`lblSubtotal`):** Suma acumulada de los vehículos.
  * **Descuentos (`lblDescuentos`):** Monto descontado si es cliente corporativo.
  * **Domicilio (`lblDomicilio`):** Cargo aplicado por envío.
  * **ITBIS (`lblItbis`):** Impuesto calculado (18%).
  * **Total General (`lblTotal`):** Monto final a pagar por el cliente.

---

## 6. Capturas de Pantalla del Programa en Ejecución

<img width="1140" height="700" alt="image" src="https://github.com/user-attachments/assets/1383704c-893a-44e6-b6ea-4488880c5680" />

<img width="1188" height="710" alt="image" src="https://github.com/user-attachments/assets/760a1026-407a-40ee-81a7-c8102247870f" />

<img width="1234" height="710" alt="image" src="https://github.com/user-attachments/assets/1593c912-d713-4a67-a12d-62f6d035493c" />

<img width="1185" height="728" alt="image" src="https://github.com/user-attachments/assets/a30432ee-8f00-4510-abe6-b0508e3a6428" />

<img width="1259" height="766" alt="image" src="https://github.com/user-attachments/assets/3b707287-426e-4ea4-a8bc-47bafea75ee9" />

<img width="1258" height="702" alt="image" src="https://github.com/user-attachments/assets/65647d46-0b8d-4215-ace1-9e3825d814ca" />



