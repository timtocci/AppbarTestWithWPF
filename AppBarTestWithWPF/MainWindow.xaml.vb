Imports WpfAppBar
Class MainWindow
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ClickMe(sender As Object, e As RoutedEventArgs) Handles MyButton.Click
        ' do something
        Background = BrushFromRGB("#ffffff", 0.15)
    End Sub

    ' this just makes life easier while testing
    Private Sub MainWindow_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Me.MouseDown
        CloseBar()
    End Sub

    ' this works but the form is visible initially
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        AppBarFunctions.SetAppBar(Me, ABEdge.Bottom, MyGrid)
    End Sub

    ' must set edge to none before closing form
    Private Sub CloseBar()
        AppBarFunctions.SetAppBar(Me, ABEdge.None)
        Me.Close()
    End Sub

    ' set edge to top
    Private Sub BtnTop_Click(sender As Object, e As RoutedEventArgs) Handles BtnTop.Click
        AppBarFunctions.SetAppBar(Me, ABEdge.None)
        MyButtons.Orientation = Orientation.Horizontal
        MyGrid.Height = 30
        AppBarFunctions.SetAppBar(Me, ABEdge.Top, MyGrid)
    End Sub

    ' set edge to right
    Private Sub BtnRight_Click(sender As Object, e As RoutedEventArgs) Handles BtnRight.Click
        AppBarFunctions.SetAppBar(Me, ABEdge.None)
        MyButtons.Orientation = Orientation.Vertical
        MyGrid.Height = 100%
        AppBarFunctions.SetAppBar(Me, ABEdge.Right, MyGrid)
    End Sub

    ' set edge to left
    Private Sub BtnLeft_Click(sender As Object, e As RoutedEventArgs) Handles BtnLeft.Click
        AppBarFunctions.SetAppBar(Me, ABEdge.None)
        MyButtons.Orientation = Orientation.Vertical
        MyGrid.Height = 100%
        AppBarFunctions.SetAppBar(Me, ABEdge.Left, MyGrid)
    End Sub

    ' set edge to bottom
    Private Sub BtnBottom_Click(sender As Object, e As RoutedEventArgs) Handles BtnBottom.Click
        AppBarFunctions.SetAppBar(Me, ABEdge.None)
        MyButtons.Orientation = Orientation.Horizontal
        MyGrid.Height = 30
        AppBarFunctions.SetAppBar(Me, ABEdge.Bottom, MyGrid)
    End Sub
End Class
