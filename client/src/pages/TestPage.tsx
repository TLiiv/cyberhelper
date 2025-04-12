import EmailDashboard from "@/components/Email/EmailDashboard";
import {
  Box,
  Button,
  Dialog,
  Portal,
  Text,
  DialogBody,
  DialogContent,
  DialogHeader,
  DialogTitle,
  DialogBackdrop,
  DialogPositioner,
  Theme,
  VStack,
  Input,
  CloseButton,
} from "@chakra-ui/react";
import { useState } from "react";
import { useNavigate } from "react-router-dom";

const TestPage: React.FC = () => {
  const [username, setUsername] = useState("");
  const [testStarted, setTestStarted] = useState(false);

  const navigate = useNavigate();

  const handleStartTest = () => {
    if (username.trim()) {
      setTestStarted(true);
    }
  };

  const handleClose = () => {
    navigate("/");
    // modal if closed twice wont let click on links anymore so we need to refresh the page...
    navigate(0);
  };

  return (
    <Box maxW="1680px" mx="auto" px={4} position="relative">
      <Theme appearance="light" borderRadius="4xl">
        <Dialog.Root
          open={!testStarted}
          unmountOnExit={true}
          modal
          preventScroll
          closeOnEscape={false}
          closeOnInteractOutside={false}
        >
          <Portal>
            <DialogBackdrop />
            <DialogPositioner>
              <DialogContent borderRadius="2xl" bg="white" maxW="lg" p={6}>
                <DialogHeader>
                  <DialogTitle
                    fontSize="2xl"
                    fontWeight="bold"
                    color="gray.800"
                  >
                    Tere tulemast andmepüügi emaili tuvastamise testi!
                  </DialogTitle>
                </DialogHeader>
                <DialogBody color="gray.800">
                  <VStack align="stretch" fontWeight="bold" p={4}>
                    <Text mt={2}>
                      Selles testis saad proovida, kui hästi suudad eristada
                      õigeid e-kirju valedest. Testis on kokku 8 taset.
                    </Text>
                    <Text mt={2}>
                      Sina pead ära arvama, kas tegemist on andmepüügi või õige
                      e-kirjaga. Alates viiendast tasemest muutuvad osad lingid
                      aktiivseks, kuna meili sisu põhjal ei ole nii lihtne aru
                      saada, kas tegemist on andmepüügiga või mitte.
                    </Text>
                    <Text mt={2}>
                      Testi oma teadlikkust ja uuri välja, kas sa suudad
                      andmepüügi eristada õigest e-kirjast. Edu!
                    </Text>
                    <Text mt={2}>
                      Enne alustamist sisesta oma nimi ja vajuta „Alusta testi”.
                    </Text>
                    <Input
                      placeholder="Sisesta oma nimi"
                      value={username}
                      onChange={(e) => setUsername(e.target.value)}
                    />
                    <Button
                      background="teal.500"
                      color="gray.100"
                      onClick={handleStartTest}
                      disabled={!username.trim()}
                    >
                      Alusta testi
                    </Button>
                  </VStack>
                </DialogBody>
                <Dialog.CloseTrigger asChild>
                  <CloseButton
                    size="md"
                    onClick={handleClose}
                    variant="solid"
                  />
                </Dialog.CloseTrigger>
              </DialogContent>
            </DialogPositioner>
          </Portal>
        </Dialog.Root>

        {testStarted && <EmailDashboard username={username} />}
      </Theme>
    </Box>
  );
};

export default TestPage;
