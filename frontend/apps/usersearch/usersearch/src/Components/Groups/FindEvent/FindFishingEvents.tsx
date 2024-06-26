type FishingEvent = {
    EventName: string, 
}

async function findFishingEvents(id: FishingEvent) {
    var response = await fetch(`https://localhost:7062/api/fishingevent/`, {
        method : "GET"

    });

    if (!response.ok)
        throw new Error("Could not call the back end. ");

    const data = await response.json();
    return data;
}


export default function getFishingEvents() {
    return(
        <div className=" flex flex-col md:flex-row items-center justify-center">
            
        </div>

    )






}