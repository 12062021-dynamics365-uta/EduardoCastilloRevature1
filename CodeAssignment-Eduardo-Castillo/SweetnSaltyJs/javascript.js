let count = 1;
let sweetnSalty = 0;
let salty = 0;
let sweet = 0;



while (count <= 1000) {
    //The while loop is for counting to 1000, the for loop is for printing in groups of 20
    for (let i = 0; i < 20; i++) {
        // if/else decide between three cases, divisible by 5, divisible by 3 or by none
        if (count % 5 == 0) {
            if (count % 3 == 0)//Check if it is also divisible by 3
            {
                console.log("sweet’nSalty ");
                sweetnSalty++;
            }
            else {
                console.log("salty ");
                salty++;
            }
        }
        else if (count % 3 == 0) {
            console.log("sweet ");
            sweet++;
        }
        else {
            console.log(count + " ");
        }
        count++;
    }//End for loop


console.log(' ');   
}//End while loop



console.log();
console.log(" ------------------------------------------------------------------------");
console.log(`Sweets: ${sweet}      Salties: ${salty}       Sweet’nSalties: ${sweetnSalty}`);