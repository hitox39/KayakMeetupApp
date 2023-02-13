

export default function Dashboard(){

    return (
        <div className='text-white bg-slate-700'>
          <div className='max-w-[800px] mt-[-96px] w-full h-screen mx-auto text-center flex flex-col justify-center'>
            <p className='text-[#00df9a] font-bold p-2'>
              Kayaker Meetup 
            </p>
            {/* <h1 className='text-[#00df9a] font-bold p-2 md:text-6lg sm:text-6lg text-4lg md:py-6'>
              add text
            </h1> */}
            <div className='flex justify-center items-center'>
              <p className='md:text-2xl sm:text-4lg text-6lg font-bold py-4'>
                A wonderful community full of passionate kayakers. Are you ready to join in on the fun?
              </p>
              
              
            </div>
            <p className='md:text-2xl text-xl font-bold text-gray-200'>Meetup and connect with local Kayakers near you</p>
            <button className='bg-[#00df9a] w-[200px] rounded-md font-medium my-6 mx-auto py-3 text-black'>Get Connected</button>
          </div>
        </div>
        )

}