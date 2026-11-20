Segundo Parcial

1. Datos del estudiante

Evaluación	Segundo Parcial

Nombre	Pedro Yunior Edubique Hernández

Matrícula	2025-1422

Carrera	Ingeniería de Software

Universidad	Universidad Central del Este (UCE)

Proyecto	Examen_RentaCar_PedroEdubique (Windows Forms, C#)

2. Descripción del programa

RentaCar Express es una aplicación de escritorio en Windows Forms, hecha en un solo formulario (frmAlquiler). Registra los alquileres de vehículos de un cliente y calcula el total a pagar, aplicando descuento corporativo, entrega a domicilio e ITBIS.

El vehículo y su tarifa se digitan manualmente (no vienen de una lista). La aplicación permite:

Agregar varios vehículos a un mismo alquiler.
Mostrar cada línea en columnas alineadas dentro de un ListBox.
Calcular subtotal, descuento, domicilio, ITBIS y total.
Iniciar un nuevo alquiler y salir con confirmación.
Reglas de negocio
Tarifa diaria = tarifa digitada + 300 si el seguro es completo + 100 si lleva GPS.
Total de línea = tarifa diaria × días. Subtotal = suma de las líneas.
Descuento = 15 % del subtotal si el cliente es corporativo.
Entrega a domicilio = RD$500, una sola vez por alquiler.
Base imponible = subtotal − descuento + entrega a domicilio.
ITBIS = 18 % de la base imponible. Total = base imponible + ITBIS.
Controles principales
Control	Nombre
Cliente	txtCliente
Fecha de salida (fecha actual)	dtpSalida
Cliente corporativo	chkCorporativo
Vehículo / Tarifa por día	txtVehiculo / txtTarifa
Días (1 a 30)	nudDias
Seguro (Básico por defecto)	rbtBasico / rbtCompleto
GPS	chkGps
Entrega (Sucursal por defecto)	rbtSucursal / rbtDomicilio
Encabezado y lista de alquileres	lblEncabezado / lstAlquileres
Resultados (formato RD$ 0.00)	lblSubtotal, lblDescuento, lblDomicilio, lblItbis, lblTotal
Botones	btnAgregar, btnCalcular, btnLimpiar, btnSalir
3. Datos de entrada
Dato	Descripción
Cliente	Nombre del cliente (txtCliente)
Fecha de salida	Fecha actual por defecto (dtpSalida)
Cliente corporativo	Marcado = aplica 15 % de descuento
Vehículo	Nombre digitado (ej. Sedán, Jeepeta)
Tarifa por día	Valor digitado en RD$ (referencia: Económico 1,500 · Sedán 2,200 · Jeepeta 3,500 · Minivan 4,000)
Días	De 1 a 30 (nudDias)
Seguro	Básico (+0) o Completo (+RD$300 por día)
GPS	+RD$100 por día
Entrega	En sucursal (+0) o a domicilio (+RD$500, una sola vez)
4. Proceso
Evento Load

Deja los controles y resultados en sus valores iniciales (seguro Básico, entrega en sucursal, 1 día, subtotal en cero) y muestra en lblEncabezado los títulos Días, Vehículo, Tarifa y Total con el mismo formato de columnas del ListBox.

Botón Agregar al alquiler (btnAgregar)
Valida que haya vehículo y una tarifa numérica mayor que cero.
Calcula la tarifa diaria: tarifa + 300 (si Completo) + 100 (si GPS).
Calcula el total de la línea: tarifa diaria × días.
Muestra la línea en lstAlquileres con PadRight/PadLeft (anchos 6, 24, 10 y 12), con el seguro entre paréntesis junto al vehículo.
Acumula el total de la línea en la variable decimal subtotal.
Reinicia los controles del vehículo (nombre, tarifa, días, seguro y GPS) para el siguiente.
Botón Calcular total (btnCalcular)
Si no hay vehículos agregados, muestra un mensaje y no calcula.
descuento = subtotal × 0.15 si es corporativo; si no, 0.
domicilio = 500 si se eligió entrega a domicilio; si no, 0.
base = subtotal − descuento + domicilio.
ITBIS = base × 0.18.
total = base + ITBIS.
Muestra todo en las etiquetas con formato RD$ 0.00.
Botón Nuevo alquiler (btnLimpiar)

Limpia todos los controles y la lista, pone el subtotal en cero y devuelve el foco a txtCliente.

Botón Salir (btnSalir)

Confirma con MessageBox (Sí/No) antes de cerrar la aplicación.

5. Salida

Resultados mostrados en pantalla, con formato RD$ 0.00:

Lista de vehículos del alquiler en columnas (Días, Vehículo, Tarifa, Total).
Subtotal, Descuento, Domicilio, ITBIS (18 %) y TOTAL A PAGAR.
Caso de prueba verificado

Carlos Méndez (corporativo), salida 20/11/2026, entrega a domicilio

Línea	Cálculo	Total
3 Sedán (Completo), tarifa 2,200	(2,200 + 300) × 3	7,500.00
2 Jeepeta (GPS), tarifa 3,500	(3,500 + 100) × 2	7,200.00
Concepto	Valor
Subtotal	RD$ 14,700.00
Descuento (15 %)	RD$ 2,205.00
Domicilio	RD$ 500.00
Base imponible	RD$ 12,995.00
ITBIS (18 %)	RD$ 2,339.10
TOTAL A PAGAR	RD$ 15,334.10
6. Capturas de pantalla

Reemplaza estas rutas con tus capturas reales (carpeta capturas/ del repositorio).

Pantalla inicial (evento Load)

Pantalla inicial

Vehículos agregados al alquiler

Vehículos agregados

Resultado del caso de prueba (RD$ 15,334.10)

Resultado final

Mensaje de confirmación al salir

Confirmar salida
