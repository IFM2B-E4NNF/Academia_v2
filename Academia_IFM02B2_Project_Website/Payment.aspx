<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Academia_IFM02B2_Project_Website.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment</title>



    <link rel="stylesheet" href=" https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <link href="assets/css/payment.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="card mt-50 mb-50">
                <div class="card-title mx-auto">Payment </div>
                <div class="nav">
                    <ul class="mx-auto">
                        <li><a href="#">Account</a></li>
                        <li class="active"><a href="#">Payment</a></li>
                    </ul>
                </div>
                <form>
                    <span id="card-header">Saved cards:</span>
                    <div class="row row-1">
                        <div class="col-2">
                            <img class="img-fluid" src="https://img.icons8.com/color/48/000000/mastercard-logo.png" /></div>
                        <div class="col-7">
                            <input type="text" placeholder="**** **** **** 3193">
                        </div>
                        <div class="col-3 d-flex justify-content-center"><a href="#">Remove card</a> </div>
                    </div>
                    <div class="row row-1">
                        <div class="col-2">
                            <img class="img-fluid" src="https://img.icons8.com/color/48/000000/visa.png" /></div>
                        <div class="col-7">
                            <input type="text" placeholder="**** **** **** 4296">
                        </div>
                        <div class="col-3 d-flex justify-content-center"><a href="#">Remove card</a> </div>
                    </div>
                    <span id="card-header">Add new card:</span>
                    <div class="row-1">
                        <div class="row row-2"><span id="card-inner">Card holder name</span> </div>
                        <div class="row row-2">
                            <input type="text" placeholder="Bojan Viner">
                        </div>
                    </div>
                    <div class="row three">
                        <div class="col-7">
                            <div class="row-1">
                                <div class="row row-2"><span id="card-inner">Card number</span> </div>
                                <div class="row row-2">
                                    <input type="text" placeholder="5134-5264-4">
                                </div>
                            </div>
                        </div>
                        <div class="col-2">
                            <input type="text" placeholder="Exp. date">
                        </div>
                        <div class="col-2">
                            <input type="text" placeholder="CVV">
                        </div>
                    </div>
                    <button class="btn d-flex mx-auto"><b>Add card</b></button>
                </form>
            </div>


        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.4/jquery.min.js"></script>
    <script type="text/javascript" src="https://js.stripe.com/v2/"></script>
    <script src="https://use.fontawesome.com/f1e0bf0cbc.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js"></script>
    <script src=" https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>




    <script src="assets/js/style.js"></script>
</body>
</html>
