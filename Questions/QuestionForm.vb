Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices
Public Class QuestionForm
    Private q As Questions
    Private buttonState As Integer
    Private origFont As Font
    Private EndText As String = ""
    Private TITLE_TEXT As String = "UNB OPEN HOUSE"
    Public Shared QUESTION_FILE = "questions.txt"


    Private Sub QuestionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = String.Concat(Me.TITLE_TEXT, " ", getYear()) 'Application Title
        Me.Title.Text = String.Concat(Me.TITLE_TEXT, " ", getYear()) 'Title Label
        Debug.Print(QuestionForm.QUESTION_FILE)
        Me.q = New Questions(Conversions.ToString(QuestionForm.QUESTION_FILE))
        Me.QuesLabel.Text = Me.q.getQuestion
        Me.buttonState = 0
        Me.origFont = Me.QuesLabel.Font
    End Sub


    Private Sub QuesLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuesLabel.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Finish.Click
        Select Case buttonState

            Case 0

                If (TrueRadio.Checked = True) Then
                    If (q.testAnswer(True)) Then
                        q.recordCorrectAnswer()
                        QuesLabel.Font = New Font(QuesLabel.Font, FontStyle.Italic)
                        QuesLabel.Text = "CORRECT!  " + q.getAnswerText()
                        TrueRadio.Hide()
                        FalseRadio.Hide()
                        q.advance()
                        Finish.Text = "Continue"
                        buttonState = 1
                    Else
                        'q.recordAnswer(False)
                        QuesLabel.Font = New Font(QuesLabel.Font, FontStyle.Italic)
                        QuesLabel.Text = "INCORRECT!  " + q.getAnswerText()
                        q.advance()
                        TrueRadio.Hide()
                        FalseRadio.Hide()
                        Finish.Text = "Continue"
                        buttonState = 1
                    End If

                ElseIf (FalseRadio.Checked = True) Then
                    If (q.testAnswer(False)) Then
                        q.recordCorrectAnswer()
                        QuesLabel.Font = New Font(QuesLabel.Font, FontStyle.Italic)
                        QuesLabel.Text = "CORRECT!  " + q.getAnswerText()
                        TrueRadio.Hide()
                        FalseRadio.Hide()
                        q.advance()
                        Finish.Text = "Continue"
                        buttonState = 1
                    Else
                        'q.recordAnswer(False)
                        QuesLabel.Font = New Font(QuesLabel.Font, FontStyle.Italic)
                        QuesLabel.Text = "INCORRECT!  " + q.getAnswerText()
                        q.advance()
                        TrueRadio.Hide()
                        FalseRadio.Hide()
                        Finish.Text = "Continue"
                        buttonState = 1
                    End If

                Else
                    MsgBox("Please select either True or False")

                End If

            Case 1

                If (q.isFinished()) Then
                    ' MsgBox(q.scoreQuestions()(1))
                    QuesLabel.Font = New Font(QuesLabel.Font, FontStyle.Bold)
                    QuesLabel.Text = "These are just some of the common myths many people hold concerning sexual issues. You answered " + "'" + q.scoreQuestionsDefault(0) + "'" + " of the 15 questions correctly. This score would have " &
"earned you a grade of " + "'" + q.scoreQuestionsDefault(1) + "'" + " if you were taking Psychology 3043, Human Sexuality. This is a very popular course offered at UNB. Remember, this is before you took the course.  Hopefully this short quiz provided you with accurate information on some of these issues.  If you were to Human Sexuality at the UNB, you could become a Sexpert in no time! "
                    Finish.Text = "Close"
                    buttonState = 2
                Else
                    QuesLabel.Font = origFont
                    QuesLabel.Text = q.getQuestion
                    TrueRadio.Show()
                    FalseRadio.Show()
                    Finish.Text = "Next"
                    buttonState = 0
                End If

            Case 2
                Me.Close()

        End Select
    End Sub

    Private Function getYear() As String
        Dim now As DateTime = New DateTime()
        now = DateTime.Now
        Return Conversions.ToString(DateAndTime.DatePart(DateInterval.Year, now, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1))
    End Function

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub







End Class
