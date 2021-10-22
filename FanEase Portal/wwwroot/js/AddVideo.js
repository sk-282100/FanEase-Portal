function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#blah').attr('src', e.target.result)
                .width(150)
                .height(200);
        };

        reader.readAsDataURL(input.files[0]);
    }
}



//document.getElementById("option2").click(){
//    mp4.style.display = block;
//    console.log("2");

//}




//function radio_op2() {
//    //var opt1 = document.getElementById("option1");
//    var opt2 = document.getElementById("option2");
//    var mp4 = document.getElementById("lbl_mp4videoFile");


//        mp4.style.display = block;
//        console.log("2");

//}