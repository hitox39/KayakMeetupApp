

export default function Hero() {

  return (
    <div className='flex items-center justify-center h-screen bg-fixed bg-center bg-cover custom-img '>
      <div className='max-w-[800px] mt-[-175px] w-full h-screen ml-[-800px] text-left flex flex-col justify-center '>
        <p className='text-[#00df9a] text-6xl font-bold p-2'>
          Kayaker Meetup
        </p>
        <div className='flex justify-center items-center '>
          <p className=' text-3xl font-bold py-4 text-gray-200'>
            A wonderful community full of passionate kayakers. Are you ready to join in on the fun?
          </p>
        </div>
        <p className=' text-2xl text-[#00df9a] font-bold text-gray-00'>Meetup and connect with local Kayakers near you</p>
        <button className='bg-[#00df9a] w-[200px] rounded-md font-medium my-6 mr-auto ml-40 py-3 text-black'>Get Connected</button>
      </div>
    </div>
  )
// centered text 'max-w-[800px] mt-[-96px] w-full h-screen mx-auto text-center flex flex-col justify-center' 
}