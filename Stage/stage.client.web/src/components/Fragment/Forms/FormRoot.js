/* eslint-disable */
import React from 'react';
import { yupResolver } from '@hookform/resolvers/yup';
import { useForm } from 'react-hook-form';
import { Link } from 'react-router-dom';


const FormRoot = ({ schema, config, event, returnPage }) => {  
 
    const {
        register,
        handleSubmit,
        formState: { errors }
    } = useForm({
        resolver: yupResolver(schema)
    });
    const FormEvent = async (data) => {
        event(data)
    }

    return (
        <div>
            <form onSubmit={handleSubmit(FormEvent)}>
                {
                    config.map((element) =>
                        <div key={element.id} className='p-3'>
                            <p>{element.label}</p>
                            <input
                                id={element.id}
                                type={element.type}
                                {...register(element.id)}
                            ></input>  
                            <p>{errors[element.id]?.message}</p>
                        </div>
                    )
                }            
                <input style={{width:100 }} type="submit" />
            </form>
            <div className="p-2">
                <Link to={returnPage} >
                    {returnPage? <button style={{width:100 }}>Voltar</button>:null}
                </Link>
            </div>           
        </div>
    );

}

export { FormRoot }