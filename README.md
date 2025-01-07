[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/LkahOtWs)
[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=17612975)
# proyecto-formatos-01


# DIAGRAMA DE SECUENCIA
## HU-01
### CA01: Visualización de Reservas Activas
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Acceder a perfil
    Sistema->>BaseDatos: Consultar reservas activas del estudiante
    BaseDatos-->>Sistema: Lista de reservas activas
    Sistema-->>Estudiante: Mostrar reservas activas
```
### CA02: Acceso al Historial de Reservas
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Acceder al historial
    Sistema->>BaseDatos: Consultar reservas pasadas del estudiante
    BaseDatos-->>Sistema: Lista de reservas anteriores
    Sistema-->>Estudiante: Mostrar historial de reservas
```
### CA03: Visualización de Detalles
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Seleccionar una reserva
    Sistema->>BaseDatos: Consultar detalles de la reserva
    BaseDatos-->>Sistema: Detalles del horario, lugar y recurso
    Sistema-->>Estudiante: Mostrar detalles de la reserva
```
### CA04: Modificación de Reserva
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Acceder a los detalles de la reserva
    Sistema->>BaseDatos: Consultar políticas de modificación
    BaseDatos-->>Sistema: Políticas permitidas
    Estudiante->>Sistema: Modificar horario o cancelar
    Sistema->>BaseDatos: Actualizar reserva
    BaseDatos-->>Sistema: Confirmación de modificación
    Sistema-->>Estudiante: Notificación de cambio exitoso
```
### CA05: Registro de Modificaciones
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Consultar historial de reservas
    Sistema->>BaseDatos: Obtener registro de modificaciones
    BaseDatos-->>Sistema: Detalles de modificaciones (usuario y razón)
    Sistema-->>Estudiante: Mostrar historial con modificaciones
```
### Criterios de Aceptación No Funcionales
#### Tiempo de Carga
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Acceder a "Mis Reservas"
    Sistema->>BaseDatos: Consultar datos de reservas
    BaseDatos-->>Sistema: Lista de reservas
    Sistema-->>Estudiante: Mostrar reservas en menos de 1 segundo
```
#### Accesibilidad
```mermaid
sequenceDiagram
    participant Usuario
    participant Sistema

    Usuario->>Sistema: Navegar por la plataforma
    Sistema-->>Usuario: Interfaz accesible y compatible con lectores de pantalla
```
## HU-02
### CA01: Notificación de Recordatorio
```mermaid
sequenceDiagram
    participant Sistema
    participant BaseDatos
    participant Estudiante

    Sistema->>BaseDatos: Consultar reservas próximas
    BaseDatos-->>Sistema: Reservas con recordatorio pendiente
    Sistema-->>Estudiante: Enviar notificación de recordatorio (30 minutos antes)
```
### CA02: Notificación de Cambios
```mermaid
sequenceDiagram
    participant Administrador
    participant Sistema
    participant BaseDatos
    participant Estudiante

    Administrador->>Sistema: Modificar una reserva
    Sistema->>BaseDatos: Registrar cambios de la reserva
    BaseDatos-->>Sistema: Confirmación de registro
    Sistema-->>Estudiante: Enviar notificación con los detalles de la modificación
```
### CA03: Notificación de Cancelación
```mermaid
sequenceDiagram
    participant Administrador
    participant Sistema
    participant BaseDatos
    participant Estudiante

    Administrador->>Sistema: Cancelar una reserva
    Sistema->>BaseDatos: Registrar cancelación
    BaseDatos-->>Sistema: Confirmación de registro
    Sistema-->>Estudiante: Enviar mensaje con razones y alternativas sugeridas
```
### CA04: Configuración de Notificaciones
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Configurar preferencias de notificación
    Sistema->>BaseDatos: Actualizar configuración de notificaciones
    BaseDatos-->>Sistema: Confirmación de actualización
    Sistema-->>Estudiante: Confirmación de preferencias actualizadas
```
### CA05: Consulta de Notificaciones Pasadas
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Consultar historial de notificaciones
    Sistema->>BaseDatos: Obtener registro de notificaciones
    BaseDatos-->>Sistema: Lista de notificaciones recibidas
    Sistema-->>Estudiante: Mostrar historial de notificaciones
```
### Criterios de Aceptación No Funcionales

#### Consistencia
```mermaid
sequenceDiagram
    participant Sistema
    participant BaseDatos
    participant Estudiante

    Sistema->>BaseDatos: Detectar evento relevante (inicio próximo o modificación)
    BaseDatos-->>Sistema: Detalles del evento
    Sistema-->>Estudiante: Enviar notificación dentro de 1 minuto
```
#### Multicanal
```mermaid
sequenceDiagram
    participant Sistema
    participant Estudiante

    Sistema->>Estudiante: Enviar notificación vía correo electrónico
    Sistema->>Estudiante: Enviar notificación vía SMS
    Sistema->>Estudiante: Enviar notificación vía push
```
## HU-03
CA01: Búsqueda por Horario
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Ingresar rango de horario
    Sistema->>BaseDatos: Consultar disponibilidad de recursos en el horario
    BaseDatos-->>Sistema: Lista de recursos disponibles
    Sistema-->>Estudiante: Mostrar recursos disponibles
```
CA02: Filtro por Características
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Aplicar filtros de características
    Sistema->>BaseDatos: Consultar recursos que cumplen los filtros
    BaseDatos-->>Sistema: Lista de recursos filtrados
    Sistema-->>Estudiante: Mostrar recursos que cumplen con los filtros
```
CA03: Notificación de Recursos Ocupados
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Intentar reservar un recurso ocupado
    Sistema->>BaseDatos: Consultar disponibilidad futura del recurso
    BaseDatos-->>Sistema: Horarios disponibles del recurso
    Sistema-->>Estudiante: Mostrar notificación y horarios en que estará libre
```
CA04: Consulta de Ocupación Futura
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Seleccionar un recurso
    Sistema->>BaseDatos: Consultar ocupación del recurso para los próximos 7 días
    BaseDatos-->>Sistema: Horarios ocupados del recurso
    Sistema-->>Estudiante: Mostrar ocupación futura
```
CA05: Compatibilidad con Software Requerido
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Ingresar el nombre del software requerido
    Sistema->>BaseDatos: Buscar laboratorios con el software específico
    BaseDatos-->>Sistema: Lista de laboratorios compatibles
    Sistema-->>Estudiante: Mostrar laboratorios con el software requerido
```
Criterios de Aceptación No Funcionales

Eficiencia en Búsqueda
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema
    participant BaseDatos

    Estudiante->>Sistema: Realizar consulta con filtros
    Sistema->>BaseDatos: Procesar búsqueda
    BaseDatos-->>Sistema: Resultados de la búsqueda (en menos de 3 segundos)
    Sistema-->>Estudiante: Mostrar resultados
```
Interfaz Amigable
```mermaid
sequenceDiagram
    participant Estudiante
    participant Sistema

    Estudiante->>Sistema: Interactuar con filtros de búsqueda
    Sistema-->>Estudiante: Mostrar opciones de filtros claros e intuitivos
```
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

