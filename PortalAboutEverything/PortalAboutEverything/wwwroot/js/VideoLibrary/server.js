function updateVideos(){
    let protocol = window.location.protocol;
    let host = location.host;
    let updateVideosEndpoint = protocol + '//' + host + '/VideoLibrary/UpdateLibrary';
    
    fetch(updateVideosEndpoint).then(_ => console.log("Update request sent!"));
}