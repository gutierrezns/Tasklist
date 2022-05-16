import React, { useState } from "react";

import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';

import { useStyles } from "./styles";
import Dialog from '../alert-dialog'

import TasksService from "../../services/taskServices";
import { useTasks } from "../../context/tasks-context";

export default function Task({ task }) {
    const { id, title } = task;
    const classes = useStyles();
    const [open, setOpen] = useState(false);
    const { setTasks } = useTasks();

    const handleClickOpen = () => {
        setOpen(true);
    };

    const handleClose = () => {
        setOpen(false);
    };

    const handleComplete = () => {
        const updatedTask = TasksService.INSTANCE.delete(task?.id);
        if (updatedTask) {
          setTasks(TasksService.INSTANCE.getAll());
        }
    };

    return (
        <>
            <Dialog
                open={open}
                handleClose={handleClose}
                task={{id,title}}
                handleComplete={handleComplete}
            />
            <Card sx={{ maxWidth: 275 }} className={classes.root} onClick={handleClickOpen} >
                <CardContent>
                    <Typography variant="h5" component="div">
                        Task #{id}
                    </Typography>
                    <Typography variant="h6" component="div">
                        {title}
                    </Typography>
                </CardContent>
            </Card>
        </>
    );
}