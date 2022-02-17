Public Class Record

    'Arreglos para cargar los combos, formato para el arreglo {data, data}
    Dim dataEstadoCivil = {"Soltero", "Casado", "Viudo", "Divorciado"}
    Dim dataGenero = {"Hombre", "Mujer", "Otro"}
    Dim tipoIdentificacion = {"Cedula", "Dimex", "Pasaporte"}


    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbEstadoCivil.Items.AddRange(dataEstadoCivil)
        cbEstadoCivil.SelectedIndex = 0

        cbgen.Items.AddRange(dataGenero)
        cbgen.SelectedIndex = 0

        cbTipoIdentificacion.Items.AddRange(tipoIdentificacion)
        cbTipoIdentificacion.SelectedIndex = 0

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            'Obtener las variables
            Dim nombre = txtNombre.Text
            Dim apellido1 = txtApellido1.Text
            Dim apellido2 = txtApellido2.Text
            Dim tipoIdentificacion = cbTipoIdentificacion.SelectedIndex
            Dim identificacion = txtIdentificacion.Text
            Dim fechaNacimiento = dtFechaNacimiento.Value
            Dim estadoCivil = cbEstadoCivil.Text
            Dim genero = cbgen.Text

            'verificar
            If String.IsNullOrEmpty(nombre) Then
                MessageBox.Show("Error", "Nombre no puede ser vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(apellido1) Then
                MessageBox.Show("Error", "Apellido no puede ser vacio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Todo esta bien, continuo

                'definir el objeto persona, instanciar la clase  
                Dim objPersona As New Persona
                'asignamos los atributos de la clase 
                objPersona.Nombre = nombre
                objPersona.Apellido1 = apellido1
                objPersona.Apellido2 = apellido2
                objPersona.TipoIdentificacion = tipoIdentificacion
                objPersona.Identificacion = identificacion
                objPersona.FechaNacimiento = fechaNacimiento
                objPersona.EstadoCivil = estadoCivil
                objPersona.Genero = genero

                'agregar el objeto persona a una lista 
                listaPersonas.Add(objPersona)

                'llamar a la tabla 
                cargarTabla()

            End If


        Catch ex As Exception
            MessageBox.Show("Error", "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cargarTabla()
        Try
            'definir una tabla
            Dim tabla As New DataTable

            'definir columnas
            tabla.Columns.Add("Nombre")
            tabla.Columns.Add("Apellido1")
            tabla.Columns.Add("Apellido2")
            'tabla.Columns.Add("tipoIdentificacion") no se muestra
            tabla.Columns.Add("Identificacion")
            tabla.Columns.Add("Fecha Nacimiento")
            tabla.Columns.Add("Estado Civil")
            tabla.Columns.Add("Genero")

            'Recorremos la lista
            If listaPersonas.Count > 0 Then
                'Recorrido
                For Each objeto As Persona In listaPersonas
                    tabla.Rows.Add(objeto.Nombre, objeto.Apellido1, objeto.Apellido2, objeto.Identificacion, objeto.FechaNacimiento, objeto.EstadoCivil, objeto.Genero)
                Next

                'Aisgnar al datagridView
                DataGridView1.DataSource = tabla

            Else
                MessageBox.Show("No hay valores para mostrar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception
            MessageBox.Show("Error", "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class