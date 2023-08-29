Public Class Questions
    Public questions(,) As String '{{"Most Parents in Canada Favour sex eduction in the schools", "Research we did in New Brunswick  found that more than 94% of Canadian parents believe that sex education should be taught in the schools.  Almost all teenagers and teachers agree, too.", "T"}, _
    '{"The most likely time for a woman to become pregnant is during her menstrual period.", "An egg is released from the woman’s ovaries midway between her menstrual periods.  This is called ovulation, and is when a women is most likely to get pregnant.  However, pregnancy can occur at any time in the menstrual cycle if a couple has penile-vaginal intercourse and does not use birth control.", "F"}}
    Private answers() As Boolean
    Dim currentQuestion As Integer
    Dim questionCount As Integer
    Dim numQuestions As Integer


    Public Sub New(ByVal file As String)
        currentQuestion = 0
        questionCount = -1
        numQuestions = 0
        loadNumQuestions(file)
        initArrays()
        loadQuestions(file)

    End Sub

    Public Function getNumQuestions() As Integer
        Return numQuestions
    End Function

    Private Sub initArrays()
        ReDim answers(numQuestions - 1)
        'init answers
        Dim b As Boolean
        For Each b In answers
            b = False
        Next
        ReDim questions(numQuestions - 1, 2)
    End Sub

    Public Sub advance()
        If (currentQuestion < numQuestions) Then
            currentQuestion += 1
        End If
    End Sub

    Public Function isFinished() As Boolean
        If currentQuestion = numQuestions Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getQuestion() As String
        Return questions(currentQuestion, 0)

    End Function

    Public Function getAnswerText() As String
        Return questions(currentQuestion, 1)
    End Function

    Public Function testAnswer(ByVal ans As Boolean) As Boolean
        Dim correctAnswer As Boolean
        If (questions(currentQuestion, 2) = "T") Then
            correctAnswer = True
        Else
            correctAnswer = False
        End If

        If (ans = correctAnswer) Then
            Return True
        Else
            Return False
        End If

    End Function
    'Records a correct answer
    Public Sub recordCorrectAnswer()
        answers(currentQuestion) = True
    End Sub

    Public Function getCurrentAnswer() As Boolean
        Return answers(currentQuestion)
    End Function

    Public Function scoreQuestions() As String()
        Dim arrayElement As Boolean
        Dim s(2) As String


        Dim score As Integer
        score = 0
        For Each arrayElement In answers
            If (arrayElement = True) Then
                score += 1
            End If
        Next

        score = (score / numQuestions) * 100
        MsgBox(score)


        Select Case score
            Case 0 To 49
                s(0) = score
                s(1) = "F"
                Return s
            Case 50 To 59
                s(0) = score
                s(1) = "D"
                Return s
            Case 60 To 69
                s(0) = score
                s(1) = "C"
                Return s
            Case 70 To 84
                s(0) = score
                s(1) = "B"
                Return s
            Case 85 To 100
                s(0) = score
                s(1) = "A"
                Return s
            Case Else
                Return s
        End Select

    End Function

    'return Alpha numeric grade, currnetly only usefull for default 15 questions
    Public Function scoreQuestionsDefault() As String()
        Dim arrayElement As Boolean
        Dim s(2) As String

        Dim score As Integer
        score = 0
        For Each arrayElement In answers
            If (arrayElement = True) Then
                score += 1
            End If
        Next

        Select Case score
            Case 0 To 7
                s(0) = score
                s(1) = "F"
                Return s
            Case 8
                s(0) = score
                s(1) = "D"
                Return s
            Case 9 To 10
                s(0) = score
                s(1) = "C"
                Return s
            Case 11 To 12
                s(0) = score
                s(1) = "B"
                Return s
            Case 12 To 15
                s(0) = score
                s(1) = "A"
                Return s
            Case Else
                Return s
        End Select

    End Function


    Private Sub loadNumQuestions(ByVal file As String)
        Using MyReader As New  _
        Microsoft.VisualBasic.FileIO.TextFieldParser _
        (file)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")
            Dim currentRow As String()

            Try
                currentRow = MyReader.ReadFields()
                numQuestions = Integer.Parse(currentRow(0))

            Catch ex As  _
            Microsoft.VisualBasic.FileIO.MalformedLineException
                MsgBox("Line " & ex.Message & _
                "is not valid and will be skipped.")
            End Try


        End Using

    End Sub

    Private Sub loadQuestions(ByVal file As String)
        Dim i As Integer
        i = 0

        Using MyReader As New  _
        Microsoft.VisualBasic.FileIO.TextFieldParser _
        (file)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim currentField As String

                    If (Not (questionCount = -1)) Then
                        For Each currentField In currentRow
                            'MsgBox(currentField)
                            questions(questionCount, i) = currentField
                            i += 1
                        Next
                    End If
                    i = 0
                    questionCount += 1

                Catch ex As  _
                Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & _
                    "is not valid and will be skipped.")
                End Try
            End While

        End Using

    End Sub

End Class
