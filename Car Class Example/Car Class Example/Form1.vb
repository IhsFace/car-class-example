Public Class Form1
    Public Class Car
        Public Property Size As String
        Public Property Speed As Integer
        Public Property Colour As String

        Public Sub New(size As String, speed As Integer, colour As String)
            Me.Size = size
            Me.Speed = speed
            Me.Colour = colour
        End Sub

        Public Sub ChangeSize(newSize As String)
            Size = newSize
        End Sub

        Public Sub ChangeSpeed(newSpeed As Integer)
            Speed = newSpeed
        End Sub

        Public Sub ChangeColour(newColour As String)
            Colour = newColour
        End Sub

        Public Sub DisplayInfo()
            Console.WriteLine("Car Size: " & Size)
            Console.WriteLine("Car Speed: " & Speed & "km/h")
            Console.WriteLine("Car Colour: " & Colour)
        End Sub
    End Class

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        Dim myCar As New Car("Medium", 100, "Red")

        Console.WriteLine("Initial Car Information:")
        myCar.DisplayInfo()

        myCar.ChangeSize("Large")
        myCar.ChangeSpeed(120)
        myCar.ChangeColour("Blue")

        Console.WriteLine(vbCrLf & "Updated Car Information:")
        myCar.DisplayInfo()

        Console.ReadLine()
    End Sub
End Class
