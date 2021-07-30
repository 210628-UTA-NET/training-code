function GetAJAXPokemon() 
{
    let xhr = new XMLHttpRequest();

    let pokemon = {};

    let pokemonName = document.querySelector("#pokemonName").value;
    
    /*
        onreadystatechange property will describe the current state of your http request
        0 - uninitialized
        1 - loading (server connection has been established)
        2 - loaded (request received and a response being sent)
        3 - interactive (response is being processed)
        4 - complete
    */

    xhr.onreadystatechange = function () 
    {
        if (this.readyState == 4 && this.status >199 && this.status < 300) 
        {
            //API gives json so we need to parse it
            pokemon = JSON.parse(xhr.responseText);
            
            //This will change the src attribute of the image tag to have the same value as the one stated in our json result
            document.querySelector(".foundPokemon img").setAttribute("src", pokemon.sprites.front_default)
        }
    }
    //This is how XMLHTTPRequest assemble its http request
    xhr.open("GET", `https://pokeapi.co/api/v2/pokemon/${pokemonName}`, true);

    //This is how it sends that request
    xhr.send();
}

function GetFetchPokemon() 
{
    let pokemonName = document.querySelector("#pokemonName2").value;

    fetch(`https://pokeapi.co/api/v2/pokemon/${pokemonName}`)
        .then(result => result.json())
        .then(pokemon => 
        {
            //This will change the src attribute of the image tag to have the same value as the one stated in our json result
            document.querySelector(".foundPokemon img").setAttribute("src", pokemon.sprites.front_default)
        });
}