var product = [
{
    Name :"Bizon energy",
    Price :1,
    ID :998756123,
    },
{
    Name:"Hell Energy",
    Price: 1 ,
    ID:89641246,
},
{
    Name:"Fuse Tea",
    Price: 1.2,
    ID:88796564,
},
{
    Name:"Cappy",
    Price:0.8,
    ID:87934655,
},
{
    Name:"Full energy",
    Price: 0.6,
    ID:874623569,
},
{
    Name:"Coca-Cola",
    Price:0.6,
    ID:5468489875,
},
{
    Name:"Full Tea",
    Price: 1 ,
    ID:987941536,
}

];
var cem=0;
var edediorta=0;
for (let i = 0; i< product.length; i++) 
{
    if (product[i].ID%2!=0) 
        {
            cem=product[i].Price+cem;
            edediorta=cem/4
            "MELLIM BURDA 4U NEYNEN IFADE EDECEYIMI BILMEDIM DEYE 4 YAZDIM"
        }
        
        
}
console.log("Cemi:"+cem+" "+"AZN")
console.log("Ededi Orta:"+" "+edediorta)
