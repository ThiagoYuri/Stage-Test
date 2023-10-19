/* eslint-disable */
import React from 'react';
import { yupResolver } from '@hookform/resolvers/yup';
import { useForm } from 'react-hook-form';


const FormRoot = ({ schema, config, event }) => {  
 
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
                        <div key={element.id}>
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
                <input type="submit" />
            </form>
        </div>
    );

}

export { FormRoot }