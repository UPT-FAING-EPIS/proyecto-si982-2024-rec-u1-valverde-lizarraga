[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/LkahOtWs)
[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=17612975)
# proyecto-formatos-01


# DIAGRAMA DE SECUENCIA
## HU-04
### CA01: Disponibilidad de Computadoras
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Buscar laboratorio
    Sistema->>BaseDatos: Consultar disponibilidad de computadoras
    BaseDatos-->>Sistema: Lista de computadoras disponibles
    Estudiante->>Sistema: Seleccionar computadora específica
    Sistema->>BaseDatos: Verificar disponibilidad de la computadora
    BaseDatos-->>Sistema: Confirmación de disponibilidad
    Sistema-->>Estudiante: Computadora disponible para reservar
```

### CA02: Notificación de No Disponibilidad
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Seleccionar computadora para reservar
    Sistema->>BaseDatos: Verificar disponibilidad
    BaseDatos-->>Sistema: Computadora no disponible
    Sistema-->>Estudiante: Notificación de no disponibilidad
```
### CA03: Restricción de Doble Reserva
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Intentar reservar segunda computadora
    Sistema->>BaseDatos: Verificar reservas existentes del estudiante
    BaseDatos-->>Sistema: Computadora ya reservada en el mismo horario
    Sistema-->>Estudiante: Notificación de restricción por doble reserva
```
### CA04: Recordatorio de Reserva Próxima
```mermaid
sequenceDiagram
    participant Sistema
    participant BaseDatos
    participant Estudiante

    Sistema->>BaseDatos: Consultar reservas activas y horarios
    BaseDatos-->>Sistema: Reservas próximas a vencer
    Sistema-->>Estudiante: Enviar notificación de recordatorio
```
### CA05: Compatibilidad de Software
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Consultar compatibilidad de software
    Sistema->>BaseDatos: Verificar software disponible en la computadora
    BaseDatos-->>Sistema: Software no disponible
    Sistema->>BaseDatos: Buscar otras computadoras con el software requerido
    BaseDatos-->>Sistema: Lista de opciones compatibles
    Sistema-->>Estudiante: Sugerir otras computadoras compatibles
```
### Criterios de Aceptación No Funcionales

#### Velocidad de Respuesta
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Seleccionar computadora y confirmar reserva
    Sistema->>BaseDatos: Guardar reserva
    BaseDatos-->>Sistema: Confirmación de almacenamiento
    Sistema-->>Estudiante: Reserva completada (menos de 2 segundos)
```
#### Seguridad de Datos
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Ingresar información personal
    Sistema->>Sistema: Cifrar datos
    Sistema->>BaseDatos: Guardar datos cifrados
    BaseDatos-->>Sistema: Confirmación de almacenamiento seguro
    Sistema-->>Estudiante: Confirmar datos protegidos
```
