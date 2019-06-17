<?php
function calcu($number){
    $result  = 1;
    for($count = 0; $count < $number; $count++){
        $result = $result*($count+1);
    }
    echo $result;
    echo "<br>";
    echo "<br>";
    $result  = 0;
    for($count = 0; $count < $number; $count++){
        $result = $result + ($count+1);
    }
    echo $result;
    echo "<br>";
    echo "<br>";
    $result  = 0;
    for($count = 0; $count < $number; $count++){
        if(($count+1)%2 == 0){

        }else{
            $result = $result + ($count+1);
        }
    }
    echo $result;
    echo "<br>";
    echo "<br>";
    $result  = 0;
    for($count = 0; $count < $number; $count++){
        if(($count+1)%2 == 0){
            $result = $result + ($count+1);
        }
    }
    echo $result;
    echo "<br>";
    echo "<br>";
    $result  = 0;
    for($count = 0; $count < $number; $count++){
        if(($count+1)%2 == 0){
            $result = $result + ($count+1)*($count+1);
        }
    }
    echo $result;
}