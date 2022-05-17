import { makeStyles } from '@mui/styles';

export const useStyles = makeStyles((theme)=>({
    root: {
        background: 'white',
        border: 0,
        color: 'white',
        padding: '20px',
        margin: '10px',

        '& .MuiCardContent-root': {
            padding: 0,
            margin: 0,
            overflow: 'hidden',
            textOverflow: "ellipsis",
            width: '200px',
            [theme.breakpoints.only('mobile')]: {
                width: '120px',
                height: '30px',
                '& h5': {
                    fontSize: 17,
                },
                '& h6': {
                    fontSize: 15,
                },
            },
        }
    },
}));
