'Imports the OPC-UA library
Imports Opc.UaFx.Client
Public Class Form1
    'Global variables creation
    Dim IP 'OPC-UA's server endpoint 
    Dim client 'Client instance

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Start up configurations (not needed)
        IP_tb.Text = "ibhlinkua_011088:48010"
        ns_tb.Text = "7"
        s_tb.Text = ".Publish.teste.struct1.u2"
        write_tb.Text = "True"

        'Button Configuration
        config_btn.Enabled = True
        Start_connection_btn.Enabled = False
        stop_btn.Enabled = False
        Read_btn.Enabled = False
        write_btn.Enabled = False
    End Sub

    Private Sub config_btn_Click(sender As Object, e As EventArgs) Handles config_btn.Click
        'Updates OPC-UA's server endpoint
        IP = "opc.tcp://" & IP_tb.Text 'OPC-UA's server endpoint 

        'Button Configuration
        config_btn.Enabled = True
        Start_connection_btn.Enabled = True
        stop_btn.Enabled = False
        Read_btn.Enabled = False
        write_btn.Enabled = False
    End Sub

    Private Sub Start_connection_btn_Click(sender As Object, e As EventArgs) Handles Start_connection_btn.Click
        'Starts the connection with the OPC-UA Server
        client = New OpcClient(Convert.ToString(IP)) 'Converts the Object from a textbox to a String and creates a new OPC-UA Client
        client.Connect() 'Tries to stablish a connection with the OPC-UA Server

        'Button Configuration
        config_btn.Enabled = False
        Start_connection_btn.Enabled = False
        stop_btn.Enabled = True
        Read_btn.Enabled = True
        write_btn.Enabled = True

    End Sub

    Private Sub stop_btn_Click(sender As Object, e As EventArgs) Handles stop_btn.Click
        'Ends the connection with the OPC-AU Server
        client.Disconnect() 'Finishes to stablish a connection with the OPC-UA Server

        'Button Configuration
        config_btn.Enabled = True
        Start_connection_btn.Enabled = True
        stop_btn.Enabled = False
        Read_btn.Enabled = False
        write_btn.Enabled = False
    End Sub

    Private Sub Read_btn_Click(sender As Object, e As EventArgs) Handles Read_btn.Click
        'Request to read a variable from the OPC-UA Server
        Dim id = "ns=" & ns_tb.Text & ";s=" & s_tb.Text 'Variable endpoint identification
        Dim OPCValue = client.ReadNode(Convert.ToString(id)) 'Converts the Object from a textbox to a String and requests the variables info
        read_tb.Text = Convert.ToString(OPCValue) 'Converts the Object from the request to a String and updates the read textbox
    End Sub

    Private Sub write_btn_Click(sender As Object, e As EventArgs) Handles write_btn.Click
        'Submits to write a variable from the OPC-UA Server
        Dim id = "ns=" & ns_tb.Text & ";s=" & s_tb.Text 'Variable endpoint identification
        Dim OPCValue = client.WriteNode(Convert.ToString(id), Convert.ToString(write_tb.Text)) 'Converts the Object from a textbox to a String and requests to write a varibale from the OPC-UA Server
    End Sub

End Class