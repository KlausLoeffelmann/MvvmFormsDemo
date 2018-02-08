<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MvvmDataGrid1_IDColumn As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim MvvmDataGrid1_FirstnameColumn As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim MvvmDataGrid1_LastnameColumn As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Dim MvvmDataGrid1_DateOfBirthColumn As ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn = New ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn()
        Me.MvvmDataGrid1 = New ActiveDevelop.EntitiesFormsLib.MvvmDataGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.MvvmManager1 = New ActiveDevelop.EntitiesFormsLib.MvvmManager(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        MvvmDataGrid1_IDColumn.TextWrapping = System.Windows.TextWrapping.NoWrap
        MvvmDataGrid1_IDColumn.DataSourceType = GetType(MvvmFormsDemoViewModelLib.Kontakt)
        MvvmDataGrid1_IDColumn.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        MvvmDataGrid1_IDColumn.Width = -1.0R
        MvvmDataGrid1_IDColumn.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        MvvmDataGrid1_IDColumn.Visibility = System.Windows.Visibility.Visible
        MvvmDataGrid1_IDColumn.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        MvvmDataGrid1_IDColumn.Header = "ID"
        MvvmDataGrid1_IDColumn.IsEnabled = True
        MvvmDataGrid1_IDColumn.BackgroundColor = System.Drawing.Color.Empty
        MvvmDataGrid1_IDColumn.ForegroundColor = System.Drawing.Color.Empty
        MvvmDataGrid1_IDColumn.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        MvvmDataGrid1_IDColumn.VerticalAlignment = System.Windows.VerticalAlignment.Top
        MvvmDataGrid1_IDColumn.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        MvvmDataGrid1_IDColumn.Name = "IDColumn"
        MvvmDataGrid1_IDColumn.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        MvvmDataGrid1_FirstnameColumn.TextWrapping = System.Windows.TextWrapping.NoWrap
        MvvmDataGrid1_FirstnameColumn.DataSourceType = GetType(MvvmFormsDemoViewModelLib.Kontakt)
        MvvmDataGrid1_FirstnameColumn.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        MvvmDataGrid1_FirstnameColumn.Width = -1.0R
        MvvmDataGrid1_FirstnameColumn.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        MvvmDataGrid1_FirstnameColumn.Visibility = System.Windows.Visibility.Visible
        MvvmDataGrid1_FirstnameColumn.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        MvvmDataGrid1_FirstnameColumn.Header = "Firstname"
        MvvmDataGrid1_FirstnameColumn.IsEnabled = True
        MvvmDataGrid1_FirstnameColumn.BackgroundColor = System.Drawing.Color.Empty
        MvvmDataGrid1_FirstnameColumn.ForegroundColor = System.Drawing.Color.Empty
        MvvmDataGrid1_FirstnameColumn.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        MvvmDataGrid1_FirstnameColumn.VerticalAlignment = System.Windows.VerticalAlignment.Top
        MvvmDataGrid1_FirstnameColumn.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        MvvmDataGrid1_FirstnameColumn.Name = "FirstnameColumn"
        MvvmDataGrid1_FirstnameColumn.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        MvvmDataGrid1_LastnameColumn.TextWrapping = System.Windows.TextWrapping.NoWrap
        MvvmDataGrid1_LastnameColumn.DataSourceType = GetType(MvvmFormsDemoViewModelLib.Kontakt)
        MvvmDataGrid1_LastnameColumn.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        MvvmDataGrid1_LastnameColumn.Width = -1.0R
        MvvmDataGrid1_LastnameColumn.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        MvvmDataGrid1_LastnameColumn.Visibility = System.Windows.Visibility.Visible
        MvvmDataGrid1_LastnameColumn.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        MvvmDataGrid1_LastnameColumn.Header = "Lastname"
        MvvmDataGrid1_LastnameColumn.IsEnabled = True
        MvvmDataGrid1_LastnameColumn.BackgroundColor = System.Drawing.Color.Empty
        MvvmDataGrid1_LastnameColumn.ForegroundColor = System.Drawing.Color.Empty
        MvvmDataGrid1_LastnameColumn.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        MvvmDataGrid1_LastnameColumn.VerticalAlignment = System.Windows.VerticalAlignment.Top
        MvvmDataGrid1_LastnameColumn.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        MvvmDataGrid1_LastnameColumn.Name = "LastnameColumn"
        MvvmDataGrid1_LastnameColumn.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        MvvmDataGrid1_DateOfBirthColumn.TextWrapping = System.Windows.TextWrapping.NoWrap
        MvvmDataGrid1_DateOfBirthColumn.DataSourceType = GetType(MvvmFormsDemoViewModelLib.Kontakt)
        MvvmDataGrid1_DateOfBirthColumn.FontWeight = System.Windows.FontWeight.FromOpenTypeWeight(400)
        MvvmDataGrid1_DateOfBirthColumn.Width = -1.0R
        MvvmDataGrid1_DateOfBirthColumn.WidthLengthUnitType = System.Windows.Controls.DataGridLengthUnitType.Star
        MvvmDataGrid1_DateOfBirthColumn.Visibility = System.Windows.Visibility.Visible
        MvvmDataGrid1_DateOfBirthColumn.CellPadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        MvvmDataGrid1_DateOfBirthColumn.Header = "DateOfBirth"
        MvvmDataGrid1_DateOfBirthColumn.IsEnabled = True
        MvvmDataGrid1_DateOfBirthColumn.BackgroundColor = System.Drawing.Color.Empty
        MvvmDataGrid1_DateOfBirthColumn.ForegroundColor = System.Drawing.Color.Empty
        MvvmDataGrid1_DateOfBirthColumn.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch
        MvvmDataGrid1_DateOfBirthColumn.VerticalAlignment = System.Windows.VerticalAlignment.Top
        MvvmDataGrid1_DateOfBirthColumn.ColumnHeaderPadding = New System.Windows.Forms.Padding(0)
        MvvmDataGrid1_DateOfBirthColumn.Name = "DateOfBirthColumn"
        MvvmDataGrid1_DateOfBirthColumn.ColumnType = ActiveDevelop.EntitiesFormsLib.ColumnType.TextAndNumbers
        CType(Me.MvvmDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MvvmManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MvvmDataGrid1
        '
        Me.MvvmDataGrid1.AllowMultiColumnFiltering = False
        Me.MvvmDataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MvvmDataGrid1.AutoGenerateColumns = False
        Me.MvvmDataGrid1.CanUserAddRows = False
        Me.MvvmDataGrid1.CanUserDeleteRows = False
        Me.MvvmDataGrid1.CanUserSortColumns = True
        MvvmDataGrid1_IDColumn.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.LostFocus), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("ID", GetType(MvvmFormsDemoViewModelLib.Kontakt)))
        Me.MvvmDataGrid1.Columns.Add(MvvmDataGrid1_IDColumn)
        MvvmDataGrid1_FirstnameColumn.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.TwoWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.LostFocus), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Firstname", GetType(MvvmFormsDemoViewModelLib.Kontakt)))
        Me.MvvmDataGrid1.Columns.Add(MvvmDataGrid1_FirstnameColumn)
        MvvmDataGrid1_LastnameColumn.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.TwoWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.LostFocus), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("Lastname", GetType(MvvmFormsDemoViewModelLib.Kontakt)))
        Me.MvvmDataGrid1.Columns.Add(MvvmDataGrid1_LastnameColumn)
        MvvmDataGrid1_DateOfBirthColumn.PropertyCellBindings.Add(New ActiveDevelop.EntitiesFormsLib.BindingSetting(ActiveDevelop.EntitiesFormsLib.MvvmBindingModes.OneWay, ActiveDevelop.EntitiesFormsLib.UpdateSourceTriggerSettings.LostFocus), New ActiveDevelop.EntitiesFormsLib.BindingProperty("Content", GetType(ActiveDevelop.EntitiesFormsLib.MvvmDataGridColumn)), Nothing, Nothing, New ActiveDevelop.EntitiesFormsLib.BindingProperty("DateOfBirth", GetType(MvvmFormsDemoViewModelLib.Kontakt)))
        Me.MvvmDataGrid1.Columns.Add(MvvmDataGrid1_DateOfBirthColumn)
        Me.MvvmDataGrid1.CustomColumnTemplateType = Nothing
        Me.MvvmDataGrid1.DataSourceType = GetType(MvvmFormsDemoViewModelLib.Kontakt)
        Me.MvvmDataGrid1.EnterAction = Nothing
        Me.MvvmManager1.SetEventBindings(Me.MvvmDataGrid1, Nothing)
        Me.MvvmDataGrid1.FilterCaseSensitive = True
        Me.MvvmDataGrid1.GridLinesVisibility = System.Windows.Controls.DataGridGridLinesVisibility.All
        Me.MvvmDataGrid1.HeadersVisibility = CType((System.Windows.Controls.DataGridHeadersVisibility.Column Or System.Windows.Controls.DataGridHeadersVisibility.Row), System.Windows.Controls.DataGridHeadersVisibility)
        Me.MvvmDataGrid1.IsFilteringEnabled = False
        Me.MvvmDataGrid1.IsGroupingEnabled = False
        Me.MvvmDataGrid1.IsReadOnly = False
        Me.MvvmDataGrid1.ItemsSource = Nothing
        Me.MvvmDataGrid1.Location = New System.Drawing.Point(15, 24)
        Me.MvvmDataGrid1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MvvmDataGrid1.Name = "MvvmDataGrid1"
        Me.MvvmDataGrid1.SelectedIndex = -1
        Me.MvvmDataGrid1.SelectedItem = Nothing
        Me.MvvmDataGrid1.SelectionMode = System.Windows.Controls.DataGridSelectionMode.[Single]
        Me.MvvmDataGrid1.Size = New System.Drawing.Size(596, 262)
        Me.MvvmDataGrid1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MvvmManager1.SetEventBindings(Me.Button1, Nothing)
        Me.Button1.Location = New System.Drawing.Point(643, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MvvmManager1.SetEventBindings(Me.Button2, Nothing)
        Me.Button2.Location = New System.Drawing.Point(642, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MvvmManager1.SetEventBindings(Me.TextBox1, Nothing)
        Me.TextBox1.Location = New System.Drawing.Point(131, 346)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(480, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.MvvmManager1.SetEventBindings(Me.Label1, Nothing)
        Me.Label1.Location = New System.Drawing.Point(22, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.MvvmManager1.SetEventBindings(Me.Label2, Nothing)
        Me.Label2.Location = New System.Drawing.Point(22, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Vorname"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MvvmManager1.SetEventBindings(Me.TextBox2, Nothing)
        Me.TextBox2.Location = New System.Drawing.Point(131, 374)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(480, 22)
        Me.TextBox2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.MvvmManager1.SetEventBindings(Me.Label3, Nothing)
        Me.Label3.Location = New System.Drawing.Point(22, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ID"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MvvmManager1.SetEventBindings(Me.TextBox3, Nothing)
        Me.TextBox3.Location = New System.Drawing.Point(131, 318)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(480, 22)
        Me.TextBox3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.MvvmManager1.SetEventBindings(Me.Label4, Nothing)
        Me.Label4.Location = New System.Drawing.Point(22, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Geburtstag"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MvvmManager1.SetEventBindings(Me.TextBox4, Nothing)
        Me.TextBox4.Location = New System.Drawing.Point(131, 402)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(480, 22)
        Me.TextBox4.TabIndex = 9
        '
        'MvvmManager1
        '
        Me.MvvmManager1.CancelButton = Nothing
        Me.MvvmManager1.ContainerControl = Me
        Me.MvvmManager1.CurrentContextGuid = New System.Guid("861fafc2-3724-48ce-9bcf-d4a6f0dc5f0b")
        Me.MvvmManager1.DataContext = Nothing
        Me.MvvmManager1.DataContextType = GetType(MvvmFormsDemoViewModelLib.MainViewModel)
        Me.MvvmManager1.DataSourceType = GetType(MvvmFormsDemoViewModelLib.MainViewModel)
        Me.MvvmManager1.DirtyStateManagerComponent = Nothing
        Me.MvvmManager1.DynamicEventHandlingList = Nothing
        Me.MvvmManager1.HostingForm = Me
        Me.MvvmManager1.HostingUserControl = Nothing
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MvvmManager1.SetEventBindings(Me.Button3, Nothing)
        Me.Button3.Location = New System.Drawing.Point(642, 318)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 50)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "OK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MvvmManager1.SetEventBindings(Me.Button4, Nothing)
        Me.Button4.Location = New System.Drawing.Point(642, 372)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 50)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 461)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MvvmDataGrid1)
        Me.MvvmManager1.SetEventBindings(Me, Nothing)
        Me.Name = "Form1"
        Me.Text = "Event Tracker"
        CType(Me.MvvmDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MvvmManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MvvmDataGrid1 As ActiveDevelop.EntitiesFormsLib.MvvmDataGrid
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents MvvmManager1 As ActiveDevelop.EntitiesFormsLib.MvvmManager
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
