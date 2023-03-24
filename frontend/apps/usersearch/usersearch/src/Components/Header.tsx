import '../index.css';

export default function Header() {
    return (
        <div className="bg-black flex justify-between items-center h-20 text-[#00df9a] px-8 font-bold " >
            <h1 className=' text-3xl font-bold '>Kayak Meetup</h1>
            <ul className='flex'>
                <li className='p-3 font-semibold text-lg'>Home</li>
                <li className='p-3 font-semibold text-lg'>Find Casual Events</li>
                <li className='p-3 font-semibold text-lg'>Find Fishing Events</li>
                <li className='p-3 font-semibold text-lg'>Find Race Events</li>
                <li className='p-3 font-semibold text-lg'></li>
            </ul>
            
            <div className="flex justify-center">
            <button className='bg-[#00df9a] w-24 rounded-md font-bold my-6 mx-4 text-black '>Sign In</button>
                <div className="relative my-6 w-60" data-te-input-wrapper-init>
                    <input
                        type="text"
                        className="peer block min-h-[auto] w-full rounded border-0 bg-[#00df9a] py-[0.32rem] px-2  leading-[1.6] outline-none transition-all duration-200 ease-linear focus:placeholder:opacity-100 data-[te-input-state-active]:placeholder:opacity-100 motion-reduce:transition-none dark:text-black [&:not([data-te-input-placeholder-active])]:placeholder:opacity-0"
                        id="headersearch"
                        placeholder="Search" />
                    <label
                        htmlFor="headersearch"
                        className="pointer-events-none absolute top-0 left-3 mb-0 max-w-[90%] origin-[0_0] truncate pt-[0.37rem] leading-[1.6] text-black transition-all duration-200 ease-out peer-focus:-translate-y-[0.9rem] peer-focus:scale-[0.8] peer-focus:text-primary peer-data-[te-input-state-active]:-translate-y-[0.9rem] peer-data-[te-input-state-active]:scale-[0.8] motion-reduce:transition-none dark:text-black dark:peer-focus:text-neutral-200"
                    >Search For Events Near You
                    </label>
                </div>
            </div>
        </div>
    );
}