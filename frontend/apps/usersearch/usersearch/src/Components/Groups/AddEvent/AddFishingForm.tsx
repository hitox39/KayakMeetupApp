type FishingForumEvent = {
    EventName: string, 
}

async function addFishingEvents(id: FishingForumEvent) {
    var response = await fetch(`https://localhost:7062/api/fishingevent/`, {
        method : "POST"
    });

    if (!response.ok)
        throw new Error("Could not call the back end. ");

    const data = await response.json();
    return data;
}

export default function AddFishingForm() {
    return (
        <div>
            <form action="" method="post" className="Add Fishing Event">
                <div className="racename">
                    <label htmlFor="RaceName">Race Name Name: </label>
                    <input type="text" name="RaceName" id="racename" required />
                </div>
                <div className="cityname">
                    <label htmlFor="cityname">City Name: </label>
                    <input type="text" name="cityName" id="cityname" required />
                </div>
                <div className="state">
                    <label htmlFor="name">State: </label>
                    <input type="text" name="name" id="name" required />
                </div>
                <div className="zipcode">
                    <label htmlFor="email">Zip Code: </label>
                    <input type="text" name="email" id="email" required />
                </div>
                <div className="address">
                    <label htmlFor="address">Address: </label>
                    <input type="text" name="name" id="name" required />
                </div>
                <div className="country">
                    <label htmlFor="country">Country: </label>
                    <input type="text" name="country" id="country" required />
                </div>
                <div className="submit">
                    <input type="submit" value="Submit!" />
                </div>
            </form>
        </div>
    )
}