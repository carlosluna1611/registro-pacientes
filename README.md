# Registro de Pacientes

![Contributors](https://img.shields.io/badge/Contributors-Carlos%20Luna-blue)
![Language](https://img.shields.io/badge/Language-C%23-blue?logo=c-sharp&logoColor=white)
![Framework](https://img.shields.io/badge/Framework-Windows%20Forms-orange)
![Status](https://img.shields.io/badge/Status-Jugable%20(Beta%20completada)-success)
![License](https://img.shields.io/badge/License-MIT-brightgreen)

---

## 📖 Descripción del Proyecto

Registro de Pacientes es una aplicación de escritorio desarrollada en C# con Windows Forms, diseñada para gestionar información de pacientes de manera eficiente y profesional. La aplicación permite capturar datos personales y específicos mediante formularios interactivos con validaciones automáticas, asegurando que la información ingresada sea correcta y completa.

Se implementaron dos ventanas principales:

1. RegistroInicial: Captura datos personales como nombres, apellidos, cédula, edad y sexo.
2. RegistroFinal: Captura información adicional como correo, teléfono, país de origen, dirección y medicamentos alergénicos.

La aplicación incluye validaciones de campos, mensajes de error específicos, confirmaciones emergentes y botones de navegación seguros (Guardar, Regresar, Salir).

---

## Características Principales

| Función | Descripción |
|---------|-------------|
| Guardar datos | Avanza a la siguiente ventana o confirma registro exitoso. |
| Salir | Cierra la aplicación de manera segura. |
| Regresar | Retorna a la ventana anterior para editar datos. |
| Validación | Comprueba automáticamente que los campos estén correctamente llenos. |

- Formularios interactivos con interfaz clara y profesional.  
- Notificaciones emergentes para confirmar registros exitosos.  
- Gestión completa de errores por campo y panel de datos.  

---

## Tecnologías Utilizadas

- Lenguaje: C#  
- Framework: Windows Forms  
- IDE recomendado: Visual Studio 2022 o superior  
- Sistema operativo: Windows  

---

## Estructura del Proyecto

RegistroPacientes/
├── RegistroPacientes.sln # Archivo de solución de Visual Studio
├── RegistroPacientes/
│ ├── RegistroInicio.cs # Formulario inicial con datos básicos
│ ├── RegistroInicio.Designer.cs
│ ├── RegistroFinal.cs # Formulario final con datos específicos
│ ├── RegistroFinal.Designer.cs
│ ├── Program.cs # Punto de entrada de la aplicación
│ └── recursos/ # Carpeta con recursos gráficos y adicionales
├── .gitignore
└── README.md # Documentación del proyecto

---

## Cómo utilizar la aplicación

1. Clona el repositorio:

```bash
git clone https://github.com/tu_usuario/RegistroPacientes.git
```
2. Abre el proyecto en Visual Studio seleccionando el archivo .sln.

3. Compila y ejecuta la aplicación.

4. Completa los formularios:

  • RegistroInicial: Datos personales del paciente.

  • RegistroFinal: Información adicional y complementaria.

5. Confirma el registro y observa los mensajes emergentes.

> **Nota:** La aplicación está diseñada como demo académica. No requiere configuraciones adicionales más allá de Visual Studio.

## Licencia Este proyecto está bajo la **Licencia MIT**. Se permite usar, modificar y distribuir el proyecto siempre que se reconozca al autor original.
