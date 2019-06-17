<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<?php include "database.php"; ?>
<body>
    <div class="d-flex flex-column flex-md-row align-items-center p-3 px-md-4 mb-3 bg-white border-bottom shadow-sm">
        <h5 class="my-0 mr-md-auto font-weight-normal">Company name</h5>
        <nav class="my-2 my-md-0 mr-md-3">
            <?php foreach ($ar_link as $link) { ?>
                <a class="p-2 text-dark" href="#"><?php echo $link ?></a>
            <?php } ?>
        </nav>
        <a class="btn btn-outline-primary" href="#">Sign up</a>
    </div>
    <div class="container">
        <div class="pricing-header px-3 py-3 pt-md-5 pb-md-4 mx-auto text-center">
            <h1 class="display-4">Employee</h1>
            <p class="lead">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book</p>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="row">
                <?php for($i = 0 ;  $i  < count($list_profile) ; $i++) {
                    $profile = $list_profile[$i];
                ?>
                    <div class="col-md-3 text-center mb-4">
                        <div class="card">
                            <img class="card-img-top " src="<?php echo $profile["img"] ?>"
                                 alt="Card image">
                            <div class="card-body">
                                <h4 class="card-title"><?php echo $profile["name"] ?></h4>
                                <p class="card-text"><?php echo $profile["des"] ?></p>
                                <a href="#" class="btn btn-primary">See Profile</a>
                            </div>
                        </div>
                    </div>
                <?php } ?>
            </div>
        </div>
    </div>
    <div class="container-fluid">
        <footer class="pt-4 my-md-5 pt-md-5 border-top  text-center">
            <div class="row">
                <div class="col-12 col-md">
                    <img class="mb-2" src="https://getbootstrap.com/docs/4.1/assets/brand/bootstrap-solid.svg" alt="" width="100" height="100">
                    <small class="d-block mb-3 text-muted">© 2017-2018</small>
                </div>
                <?php foreach ($ar_link as $link) { ?>
                    <div class="col-6 col-md">
                        <h5><?php echo $link ?></h5>
                        <ul class="list-unstyled text-small">
                            <?php foreach ($ar_link2 as $link2) { ?>
                                <li><a class="text-muted" href="#"><?php echo $link2?></a></li>
                            <?php } ?>
                        </ul>
                    </div>
                <?php } ?>
            </div>
        </footer>
    </div>
</body>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/holder/2.9.6/holder.min.js" integrity="sha256-yF/YjmNnXHBdym5nuQyBNU62sCUN9Hx5awMkApzhZR0=" crossorigin="anonymous"></script>
</html>