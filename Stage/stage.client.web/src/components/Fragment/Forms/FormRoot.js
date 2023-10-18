/* eslint-disable */
import React from 'react';
import * as yup from 'yup';
import { yupResolver } from '@hookform/resolvers/yup';
import { useForm } from 'react-hook-form';
import { DevTool } from "@hookform/devtools";


const FormRoot = ({ schema, config, event }) => {  
 
    const {
        register,
        handleSubmit,
        formState: { errors }
    } = useForm({
        resolver: yupResolver(schema)
    });
    
    return (
        <div>
            <form onSubmit={handleSubmit(event)}>
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